using System.Collections.Generic;
using UnityEngine;
using Puzzz.Objects;
using Puzzz.Puzzle;
using Puzzz.Core;

namespace Puzzz.Input
{
    public class DragChainInputHandler : MonoBehaviour
    {
        [SerializeField] private GameManager _gameManager;
        [SerializeField] private int _minChainLength = 2;

        private readonly List<MatchObject> _chain = new List<MatchObject>();
        private bool _isDragging;

        private void Update()
        {
            if (_gameManager.IsStageOver) return;

            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                BeginChain();
            }
            else if (_isDragging && UnityEngine.Input.GetMouseButton(0))
            {
                ContinueChain();
            }
            else if (_isDragging && UnityEngine.Input.GetMouseButtonUp(0))
            {
                EndChain();
            }
        }

        private MatchObject GetObjectUnderPointer()
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            var hit = Physics2D.OverlapPoint(worldPoint);
            return hit == null ? null : hit.GetComponent<MatchObject>();
        }

        private void BeginChain()
        {
            var obj = GetObjectUnderPointer();
            if (obj == null) return;

            _isDragging = true;
            _chain.Clear();
            _chain.Add(obj);
        }

        private void ContinueChain()
        {
            var obj = GetObjectUnderPointer();
            if (obj == null) return;

            // 바로 이전 칸으로 되돌아가면 체인을 한 칸 축소
            if (_chain.Count >= 2 && obj == _chain[_chain.Count - 2])
            {
                _chain.RemoveAt(_chain.Count - 1);
                return;
            }

            if (_chain.Contains(obj)) return;

            var last = _chain[_chain.Count - 1];
            if (obj.Color != last.Color) return;
            if (!ChainRules.IsAdjacent(last, obj)) return;

            _chain.Add(obj);
        }

        private void EndChain()
        {
            _isDragging = false;

            if (_chain.Count >= _minChainLength)
            {
                _gameManager.ResolveChain(new List<MatchObject>(_chain));
            }

            _chain.Clear();
        }
    }
}
