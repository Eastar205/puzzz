using System.Collections.Generic;
using UnityEngine;
using Puzzz.Objects;
using Puzzz.Battle;
using Puzzz.Puzzle;

namespace Puzzz.Core
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private PuzzleBoard _puzzleBoard;
        [SerializeField] private CharacterRoster _roster;
        [SerializeField] private BattleManager _battleManager;
        [SerializeField] private WaveManager _waveManager;

        public bool IsStageOver { get; private set; }

        private void Start()
        {
            _puzzleBoard.FillInitialBoard();
            _waveManager.OnBaseDestroyed += HandleDefeat;
        }

        public void ResolveChain(List<MatchObject> chain)
        {
            var color = chain[0].Color;
            int chainLength = chain.Count;

            if (color == ObjectColor.Purple)
            {
                float duration = ManaFormula.CalculatePurpleBuffDuration(chainLength);
                _battleManager.ApplyAttackSpeedBuff(duration);
            }
            else
            {
                var character = _roster.GetByElement(color);
                character?.AddMana(ManaFormula.CalculateManaGain(chainLength));
            }

            var columnCounts = new Dictionary<int, int>();
            foreach (var orb in chain)
            {
                int column = _puzzleBoard.GetColumnFromPosition(orb.transform.position.x);
                columnCounts.TryGetValue(column, out int count);
                columnCounts[column] = count + 1;
                Destroy(orb.gameObject);
            }

            foreach (var entry in columnCounts)
            {
                _puzzleBoard.RefillColumn(entry.Key, entry.Value);
            }
        }

        private void HandleDefeat()
        {
            IsStageOver = true;
        }
    }
}
