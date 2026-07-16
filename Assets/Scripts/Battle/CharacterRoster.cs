using System.Collections.Generic;
using UnityEngine;
using Puzzz.Objects;

namespace Puzzz.Battle
{
    public class CharacterRoster : MonoBehaviour
    {
        [SerializeField] private Character _redWarrior;
        [SerializeField] private Character _blueMage;
        [SerializeField] private Character _greenArcher;
        [SerializeField] private Character _yellowHealer;

        // 전열부터 후열 순서. 몬스터는 이 순서대로 살아있는 첫 캐릭터를 공격한다.
        private Character[] _formation;

        private void Awake()
        {
            _formation = new[] { _redWarrior, _blueMage, _greenArcher, _yellowHealer };
        }

        public IEnumerable<Character> AllCharacters
        {
            get
            {
                yield return _redWarrior;
                yield return _blueMage;
                yield return _greenArcher;
                yield return _yellowHealer;
            }
        }

        /// <summary>몬스터가 현재 공격해야 할, 진형에서 가장 앞에 살아있는 캐릭터. 전멸 시 null.</summary>
        public Character GetFrontlineAlive()
        {
            foreach (var character in _formation)
            {
                if (character.IsAlive) return character;
            }
            return null;
        }

        public Character GetByElement(ObjectColor element)
        {
            return element switch
            {
                ObjectColor.Red => _redWarrior,
                ObjectColor.Blue => _blueMage,
                ObjectColor.Green => _greenArcher,
                ObjectColor.Yellow => _yellowHealer,
                _ => null
            };
        }
    }
}
