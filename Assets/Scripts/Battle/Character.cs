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

        public event Action OnSkillReady;
        public event Action OnSkillCast;

        public void AddMana(float amount)
        {
            if (IsSkillReady) return;

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
            if (_skillMode == SkillActivationMode.Manual && IsSkillReady)
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
