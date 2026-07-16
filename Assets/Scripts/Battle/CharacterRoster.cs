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
