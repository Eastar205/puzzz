using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Puzzz.Battle
{
    /// <summary>
    /// 웨이브 단위로 몬스터를 스폰하고 관리하는 매니저.
    /// 웨이브 내 몬스터는 spawnDelay == 0이면 동시에, 양수이면 순차 딜레이로 등장한다.
    /// 몬스터는 진형(캐릭터 라인)을 먼저 공격하며, 진형이 전멸해야 기지에 도달해 즉시 게임오버가 된다.
    /// </summary>
    public class WaveManager : MonoBehaviour
    {
        [Header("프리팹 & 트랜스폼")]
        [SerializeField] private Monster _monsterPrefab;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Transform _engagePoint;
        [SerializeField] private Transform _baseTarget;
        [SerializeField] private CharacterRoster _roster;

        [Header("시작 웨이브")]
        [SerializeField] private int _startWaveId = 1;

        [Header("웨이브 간 대기 시간(초)")]
        [SerializeField] private float _waveBreakDuration = 2f;

        // ── 상태 ──────────────────────────────────────────
        private readonly List<Monster> _activeMonsters = new List<Monster>();
        private int  _currentWaveId;
        private bool _isWaveInProgress;
        private bool _isDefeated;

        // ── 프로퍼티 ──────────────────────────────────────
        public int  CurrentWaveId => _currentWaveId;
        public int  AliveCount    => _activeMonsters.Count;
        public bool IsDefeated    => _isDefeated;

        // ── 이벤트 ────────────────────────────────────────
        /// <summary>현재 웨이브의 몬스터를 모두 처치했을 때</summary>
        public event Action<int> OnWaveCleared;   // 파라미터: 클리어한 waveId

        /// <summary>몬스터가 진형을 뚫고 기지에 도달했을 때 (즉시 게임오버)</summary>
        public event Action OnBaseDestroyed;

        /// <summary>다음 웨이브 데이터를 찾을 수 없어 스테이지가 완전히 끝났을 때</summary>
        public event Action OnStageComplete;

        // ─────────────────────────────────────────────────
        private void Start()
        {
            LoadWave(_startWaveId);
        }

        // ════════════════════════════════════════════════
        //  웨이브 로드 & 스폰
        // ════════════════════════════════════════════════

        /// <summary>JSON 리소스에서 웨이브를 로드하고 스폰 코루틴을 시작한다.</summary>
        public void LoadWave(int waveId)
        {
            var json = Resources.Load<TextAsset>($"Waves/wave_{waveId:D2}");
            if (json == null)
            {
                Debug.LogWarning($"[WaveManager] 더 이상 웨이브가 없습니다 (wave_{waveId:D2}). 스테이지 완료.");
                OnStageComplete?.Invoke();
                return;
            }

            _currentWaveId = waveId;
            var wave = JsonUtility.FromJson<WaveDefinition>(json.text);

            _isWaveInProgress = true;
            StartCoroutine(SpawnRoutine(wave));

            Debug.Log($"[WaveManager] Wave {waveId} 시작 — 몬스터 {wave.monsters.Count}마리");
        }

        /// <summary>
        /// 스폰 루틴: spawnDelay 기준으로 몬스터를 순차/동시 스폰.
        /// spawnDelay == 0인 항목들은 이전 yield 없이 연속 스폰되므로 사실상 동시 등장.
        /// </summary>
        private IEnumerator SpawnRoutine(WaveDefinition wave)
        {
            foreach (var spawn in wave.monsters)
            {
                if (spawn.spawnDelay > 0f)
                    yield return new WaitForSeconds(spawn.spawnDelay);

                SpawnMonster(spawn);
            }
        }

        private void SpawnMonster(MonsterSpawn spawnData)
        {
            var monster = Instantiate(_monsterPrefab, _spawnPoint.position, Quaternion.identity);
            monster.Init(spawnData.hp, _engagePoint, _baseTarget, _roster, spawnData.speedMultiplier);
            monster.OnDied += () => HandleMonsterDied(monster);
            monster.OnReachedBase += HandleMonsterReachedBase;
            _activeMonsters.Add(monster);
        }

        // ════════════════════════════════════════════════
        //  이벤트 핸들러
        // ════════════════════════════════════════════════

        private void HandleMonsterDied(Monster monster)
        {
            _activeMonsters.Remove(monster);
            TryTriggerWaveCleared();
        }

        private void HandleMonsterReachedBase()
        {
            _isDefeated = true;
            OnBaseDestroyed?.Invoke();
        }

        /// <summary>살아있는 몬스터가 0이 되면 웨이브 클리어 이벤트를 발행한다.</summary>
        private void TryTriggerWaveCleared()
        {
            _activeMonsters.RemoveAll(m => m == null);
            if (_activeMonsters.Count > 0 || !_isWaveInProgress) return;

            _isWaveInProgress = false;
            int clearedId = _currentWaveId;
            OnWaveCleared?.Invoke(clearedId);

            // 자동으로 다음 웨이브 로드
            StartCoroutine(LoadNextWaveAfterDelay(clearedId + 1));
        }

        private IEnumerator LoadNextWaveAfterDelay(int nextWaveId)
        {
            yield return new WaitForSeconds(_waveBreakDuration);
            if (!_isDefeated)
                LoadWave(nextWaveId);
        }

        // ════════════════════════════════════════════════
        //  외부 인터페이스
        // ════════════════════════════════════════════════

        /// <summary>
        /// 가장 기지에 가까운 몬스터(=기지 방향으로 가장 많이 이동한 몬스터)를 반환.
        /// BattleManager가 공격 타겟으로 사용한다.
        /// </summary>
        public Monster GetFrontTarget()
        {
            _activeMonsters.RemoveAll(m => m == null);
            if (_activeMonsters.Count == 0) return null;

            // 기지 방향으로 가장 가까운 = 기지 위치와의 거리가 가장 짧은 몬스터
            return _activeMonsters
                .OrderBy(m => Vector2.Distance(m.transform.position, _baseTarget.position))
                .FirstOrDefault();
        }
    }
}
