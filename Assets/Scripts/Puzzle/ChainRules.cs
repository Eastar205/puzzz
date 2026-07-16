using UnityEngine;
using Puzzz.Objects;

namespace Puzzz.Puzzle
{
    public static class ChainRules
    {
        public static bool IsAdjacent(MatchObject a, MatchObject b)
        {
            float maxDistance = a.ConnectionRadius + b.ConnectionRadius;
            return Vector2.Distance(a.transform.position, b.transform.position) <= maxDistance;
        }
    }
}
