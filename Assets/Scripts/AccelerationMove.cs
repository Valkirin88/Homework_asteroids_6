using UnityEngine;

namespace SpacePatterns
{
    internal class AccelerationMove : MoveRigidbody
    {
        private readonly float _acceleration;
        public AccelerationMove(Transform transform, float speed, Rigidbody2D rigidbody, float acceleration) : base(transform, speed, rigidbody)
        {
            _acceleration = acceleration;
        }
        public void AddAcceleration()
        {
            Speed += _acceleration;
        }
        public void RemoveAcceleration()
        {
            Speed -= _acceleration;
        }
    }
}
