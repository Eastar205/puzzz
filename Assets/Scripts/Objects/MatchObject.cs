using UnityEngine;

namespace Puzzz.Objects
{
    [RequireComponent(typeof(Rigidbody2D), typeof(Collider2D))]
    public class MatchObject : MonoBehaviour
    {
        public ObjectColor Color;
        public float ConnectionRadius = 0.6f;
    }
}
