using System.Collections.Generic;
using UnityEngine;
using Puzzz.Objects;

namespace Puzzz.Battle
{
    public class BattleManager : MonoBehaviour
    {
        [SerializeField] private CharacterRoster _roster;
        [SerializeField] private WaveManager _waveManager;
        [SerializeField] private float _baseAttackInterval = 1.5f;
        [SerializeField] private float _baseAttackDamage = 8f;
        [SerializeField] private float _skillDamage = 60f;
        [SerializeField] private float _healAmount = 40f;
        [SerializeField] private float _buffAttackSpeedMultiplier = 2f;

        private readonly Dictionary<Character, float> _attackTimers = new Dictionary<Character, float>();
        private float _attackSpeedMultiplier = 1f;
        private float _buffTimeRemaining;

        private void Start()
        {
            foreach (var character in _roster.AllCharacters)
            {
                _attackTimers[character] = 0f;
                character.OnSkillCast += () => HandleSkillCast(character);
            }
        }

        private void Update()
        {
            TickAttackSpeedBuff();
            TickAutoAttacks();
        }

        private void TickAttackSpeedBuff()
        {
            if (_buffTimeRemaining <= 0f) return;

            _buffTimeRemaining -= Time.deltaTime;
            if (_buffTimeRemaining <= 0f)
            {
                _attackSpeedMultiplier = 1f;
            }
        }

        private void TickAutoAttacks()
        {
            var target = _waveManager.GetFrontTarget();
            if (target == null) return;

            foreach (var character in _roster.AllCharacters)
            {
                _attackTimers[character] += Time.deltaTime * _attackSpeedMultiplier;
                if (_attackTimers[character] < _baseAttackInterval) continue;

                _attackTimers[character] = 0f;
                target.TakeDamage(_baseAttackDamage);
            }
        }

        private void HandleSkillCast(Character character)
        {
            if (character.Element == ObjectColor.Yellow)
            {
                _waveManager.HealBase(_healAmount);
                return;
            }

            var target = _waveManager.GetFrontTarget();
            target?.TakeDamage(_skillDamage);
        }

        public void ApplyAttackSpeedBuff(float duration)
        {
            _attackSpeedMultiplier = _buffAttackSpeedMultiplier;
            _buffTimeRemaining = duration;
        }
    }
}
