using UnityEngine;

namespace SpacePatterns
{
    [RequireComponent(typeof(Rigidbody))]
    internal sealed class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        private Camera _camera;
        private Vector3 _move;
        private const string _horizontalAxis = "Horizontal";
        private const string _verticalAxis = "Vertical";
        private Ship _ship;
        private Rigidbody2D _rigidbody;
        private void Start()
        {
            _camera = Camera.main;
            _rigidbody = GetComponent<Rigidbody2D>();
            var moveTransform = new AccelerationMove(transform, _speed, _rigidbody, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);
        }
        private void Update()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);
            _ship.Move(Input.GetAxis(_horizontalAxis), Input.GetAxis(_verticalAxis), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _ship.AddAcceleration();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _ship.RemoveAcceleration();
            }
        }
    }
}
