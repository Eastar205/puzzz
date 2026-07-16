using System;
using UnityEngine;
using Puzzz.Objects;

namespace Puzzz.Battle
{
    public class Character : MonoBehaviour
    {
        [SerializeField] private string _characterName;
        [SerializeField] private ObjectColor _element;
        [SerializeField] private SkillActivationMode _skillMode = SkillActivationMode.Auto;
        [SerializeField] private float _maxMana = 100f;

        [Header("전투 스탯 (캐릭터별로 다르게 설정)")]
        [SerializeField] private float _maxHp = 100f;
        [SerializeField] private float _attackDamage = 8f;
        [SerializeField] private float _attackInterval = 1.5f;

        public string CharacterName => _characterName;
        public ObjectColor Element => _element;
        public float MaxMana => _maxMana;
        public float CurrentMana { get; private set; }
        public bool IsSkillReady => CurrentMana >= _maxMana;
        public SkillActivationMode SkillMode
        {
            get => _skillMode;
            set => _skillMode = value;
        }

        public float MaxHp => _maxHp;
        public float CurrentHp { get; private set; }
        public bool IsAlive => CurrentHp > 0f;
        public float AttackDamage => _attackDamage;
        public float AttackInterval => _attackInterval;

        public event Action OnSkillReady;
        public event Action OnSkillCast;

        private void Awake()
        {
            CurrentHp = _maxHp;
        }

        public void TakeDamage(float amount)
        {
            if (!IsAlive) return;
            CurrentHp = Mathf.Max(0f, CurrentHp - amount);
        }

        public void Heal(float amount)
        {
            if (!IsAlive) return;
            CurrentHp = Mathf.Min(_maxHp, CurrentHp + amount);
        }

        public void AddMana(float amount)
        {
            if (!IsAlive || IsSkillReady) return;

            CurrentMana = Mathf.Min(_maxMana, CurrentMana + amount);
            if (!IsSkillReady) return;

            if (_skillMode == SkillActivationMode.Auto)
            {
                CastSkill();
            }
            else
            {
                OnSkillReady?.Invoke();
            }
        }

        public void TryManualCast()
        {
            if (IsAlive && _skillMode == SkillActivationMode.Manual && IsSkillReady)
            {
                CastSkill();
            }
        }

        private void CastSkill()
        {
            CurrentMana = 0f;
            OnSkillCast?.Invoke();
        }
    }
}
