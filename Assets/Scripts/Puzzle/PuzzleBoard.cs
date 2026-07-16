using UnityEngine;
using Puzzz.Objects;

namespace Puzzz.Puzzle
{
    public class PuzzleBoard : MonoBehaviour
    {
        [SerializeField] private MatchObject _orbPrefabRed;
        [SerializeField] private MatchObject _orbPrefabBlue;
        [SerializeField] private MatchObject _orbPrefabGreen;
        [SerializeField] private MatchObject _orbPrefabYellow;
        [SerializeField] private MatchObject _orbPrefabPurple;

        [SerializeField] private int _columns = 7;
        [SerializeField] private int _rows = 7;
        [SerializeField] private float _cellSpacing = 0.85f;
        [SerializeField] private float _spawnY = 4.5f;
        [SerializeField, Range(0f, 1f)] private float _purpleChance = 0.05f;

        public void FillInitialBoard()
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col < _columns; col++)
                {
                    SpawnOrb(col, GetSlotY(row));
                }
            }
        }

        public void RefillColumn(int column, int missingCount)
        {
            for (int i = 0; i < missingCount; i++)
            {
                SpawnOrb(column, _spawnY + i * _cellSpacing);
            }
        }

        public float GetColumnX(int column)
        {
            float half = (_columns - 1) / 2f;
            return (column - half) * _cellSpacing;
        }

        public int GetColumnFromPosition(float x)
        {
            float half = (_columns - 1) / 2f;
            return Mathf.RoundToInt(x / _cellSpacing + half);
        }

        private float GetSlotY(int row)
        {
            float half = (_rows - 1) / 2f;
            return (half - row) * _cellSpacing;
        }

        private void SpawnOrb(int column, float y)
        {
            var color = RollOrbColor();
            var prefab = GetPrefab(color);
            var position = new Vector3(GetColumnX(column), y, 0f);
            var instance = Instantiate(prefab, position, Quaternion.identity, transform);
            instance.Color = color;
        }

        private ObjectColor RollOrbColor()
        {
            if (Random.value < _purpleChance) return ObjectColor.Purple;

            int roll = Random.Range(0, 4);
            return roll switch
            {
                0 => ObjectColor.Red,
                1 => ObjectColor.Blue,
                2 => ObjectColor.Green,
                _ => ObjectColor.Yellow,
            };
        }

        private MatchObject GetPrefab(ObjectColor color)
        {
            return color switch
            {
                ObjectColor.Red => _orbPrefabRed,
                ObjectColor.Blue => _orbPrefabBlue,
                ObjectColor.Green => _orbPrefabGreen,
                ObjectColor.Yellow => _orbPrefabYellow,
                _ => _orbPrefabPurple,
            };
        }
    }
}
