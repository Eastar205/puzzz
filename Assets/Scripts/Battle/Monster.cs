using System;
using UnityEngine;

namespace Puzzz.Battle
{
    /// <summary>
    /// 진형(전사 → 마법사 → 궁수 → 힐러) 중 가장 앞에 살아있는 캐릭터를 향해 이동하다가,
    /// 사거리에 들어오면 멈춰서 공격한다. 진형이 전멸하면 기지로 이동해 즉시 게임오버를 유발한다.
    /// </summary>
    public class Monster : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 0.5f;
        [SerializeField] private float _attackDamage = 8f;
        [SerializeField] private float _attackInterval = 1f;

        private Transform _engagePoint;
        private Transform _baseTarget;
        private CharacterRoster _roster;
        private float _attackTimer;
        private bool _reachedBase;

        public float CurrentHp { get; private set; }
        public bool IsDead => CurrentHp <= 0f;

        public event Action OnDied;
        public event Action OnReachedBase;

        public void Init(float hp, Transform engagePoint, Transform baseTarget, CharacterRoster roster, float speedMultiplier = 1f)
        {
            CurrentHp = hp;
            _engagePoint = engagePoint;
            _baseTarget = baseTarget;
            _roster = roster;
            _moveSpeed *= speedMultiplier;
        }

        private void Update()
        {
            if (IsDead || _reachedBase) return;

            var blocker = _roster.GetFrontlineAlive();
            var targetPoint = blocker != null ? _engagePoint : _baseTarget;

            if (Vector2.Distance(transform.position, targetPoint.position) > 0.1f)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPoint.position, _moveSpeed * Time.deltaTime);
                return;
            }

            if (blocker == null)
            {
                _reachedBase = true;
                OnReachedBase?.Invoke();
                Destroy(gameObject);
                return;
            }

            _attackTimer += Time.deltaTime;
            if (_attackTimer >= _attackInterval)
            {
                _attackTimer = 0f;
                blocker.TakeDamage(_attackDamage);
            }
        }

        public void TakeDamage(float amount)
        {
            if (IsDead) return;

            CurrentHp = Mathf.Max(0f, CurrentHp - amount);
            if (IsDead)
            {
                OnDied?.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
