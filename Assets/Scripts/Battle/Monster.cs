using System;
using UnityEngine;

namespace Puzzz.Battle
{
    public class Monster : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 0.5f;
        [SerializeField] private float _baseDamage = 10f;

        private Transform _baseTarget;
        private bool _reachedBase;

        public float CurrentHp { get; private set; }
        public bool IsDead => CurrentHp <= 0f;

        public event Action OnDied;
        public event Action<float> OnReachedBase;

        public void Init(float hp, Transform baseTarget)
        {
            CurrentHp = hp;
            _baseTarget = baseTarget;
        }

        private void Update()
        {
            if (IsDead || _reachedBase || _baseTarget == null) return;

            transform.position = Vector2.MoveTowards(transform.position, _baseTarget.position, _moveSpeed * Time.deltaTime);
            if (Vector2.Distance(transform.position, _baseTarget.position) < 0.1f)
            {
                _reachedBase = true;
                OnReachedBase?.Invoke(_baseDamage);
                Destroy(gameObject);
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
