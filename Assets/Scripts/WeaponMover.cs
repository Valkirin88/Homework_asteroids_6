using UnityEngine;
using Object = UnityEngine.Object;

namespace SpacePatterns
{
    public sealed class WeaponMover 
    {
        private GameObject _gameObject;
        private float _force = 15.0f;
        private Rigidbody2D _gameObjectRigidBody;

        public WeaponMover(GameObject gameObject)
        {
            _gameObject = gameObject;
            _gameObjectRigidBody = _gameObject.GetComponent<Rigidbody2D>();
            WeaponMove(_gameObjectRigidBody);
        }

        public void WeaponMove(Rigidbody2D gameObjectRigidbody2D)
        {
            gameObjectRigidbody2D.AddForce(Vector3.forward * _force);
        }
    }
}