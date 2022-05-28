using UnityEngine;

namespace SpacePatterns
{
    internal class MoveRigidbody : IMove 
    {
        private readonly Transform _transform;
        private Vector3 _move;
        private Rigidbody2D _rigidbodyPlayer;
        public float Speed { get; protected set; }
        public MoveRigidbody(Transform transform,  float speed, Rigidbody2D rigidbody)
        {
            _transform = transform;
            Speed = speed;
            _rigidbodyPlayer = rigidbody;
        }
        public void Move (float horizontal, float vertical, float deltaTime)
        {
           var speed = deltaTime * Speed;
           _move.Set(horizontal * speed, vertical * speed, 0.0f);
           _rigidbodyPlayer.AddForce(_move, ForceMode2D.Impulse);
        }
    }
}