using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Puzzz.Battle
{
    public class WaveManager : MonoBehaviour
    {
        [SerializeField] private Monster _monsterPrefab;
        [SerializeField] private Transform _spawnPoint;
        [SerializeField] private Transform _baseTarget;
        [SerializeField] private int _waveId = 1;

        private readonly List<Monster> _activeMonsters = new List<Monster>();
        private float _baseHp;
        private float _maxBaseHp;

        public float BaseHp => _baseHp;
        public float MaxBaseHp => _maxBaseHp;
        public bool IsBaseDestroyed => _baseHp <= 0f;

        public event Action OnWaveCleared;
        public event Action OnBaseDestroyed;

        private void Start()
        {
            LoadWave(_waveId);
        }

        private void LoadWave(int waveId)
        {
            var json = Resources.Load<TextAsset>($"Waves/wave_{waveId:D2}");
            if (json == null)
            {
                Debug.LogError($"웨이브 데이터를 찾을 수 없습니다: wave_{waveId:D2}");
                return;
            }

            var wave = JsonUtility.FromJson<WaveDefinition>(json.text);
            _baseHp = wave.baseHp;
            _maxBaseHp = wave.baseHp;
            StartCoroutine(SpawnRoutine(wave));
        }

        private IEnumerator SpawnRoutine(WaveDefinition wave)
        {
            foreach (var spawn in wave.monsters)
            {
                yield return new WaitForSeconds(spawn.spawnDelay);
                SpawnMonster(spawn.hp);
            }
        }

        private void SpawnMonster(float hp)
        {
            var monster = Instantiate(_monsterPrefab, _spawnPoint.position, Quaternion.identity);
            monster.Init(hp, _baseTarget);
            monster.OnDied += () => HandleMonsterDied(monster);
            monster.OnReachedBase += HandleMonsterReachedBase;
            _activeMonsters.Add(monster);
        }

        private void HandleMonsterDied(Monster monster)
        {
            _activeMonsters.Remove(monster);
            if (_activeMonsters.Count == 0)
            {
                OnWaveCleared?.Invoke();
            }
        }

        private void HandleMonsterReachedBase(float damage)
        {
            _activeMonsters.RemoveAll(m => m == null);
            _baseHp = Mathf.Max(0f, _baseHp - damage);
            if (IsBaseDestroyed)
            {
                OnBaseDestroyed?.Invoke();
            }
        }

        public Monster GetFrontTarget()
        {
            _activeMonsters.RemoveAll(m => m == null);
            return _activeMonsters.Count > 0 ? _activeMonsters[0] : null;
        }

        public void HealBase(float amount)
        {
            _baseHp = Mathf.Min(_maxBaseHp, _baseHp + amount);
        }
    }
}
