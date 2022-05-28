using UnityEngine;

namespace SpacePatterns
{
    [RequireComponent(typeof(Rigidbody))]
    internal sealed class PlayerShooting : MonoBehaviour
    {
        private GameObject _bullet;
        private Rigidbody _bulletRigidbody;
        private Bullet _bulletShooting;
        private Missiles _missiles;
        [SerializeField] private Sprite _sprite;
        [SerializeField] private GameObject _barrel;
        [SerializeField] private float _force =100;
        private const string _fire1 = "Fire1";
        private const string _fire2 = "Fire2";
        private const string _bulletPrefab = "Bullet";
        private readonly int _capacityPool =10;
       

        void Awake()
        {
            _bullet = Resources.Load<GameObject>(_bulletPrefab);
            _bulletRigidbody = _bullet.GetComponent<Rigidbody>();
            _bulletShooting = new Bullet(_bulletRigidbody, _barrel.transform, _force);

            var bullet = Resources.Load<Weapon>(_bulletPrefab);
            WeaponPool weaponPool = new WeaponPool(bullet, _capacityPool, _barrel.transform);
            _missiles = new Missiles(_bulletRigidbody, _barrel.transform, _force);

        }

        void Update()
        {
            if (Input.GetButtonDown(_fire1))
            {
                _bulletShooting.Attack();
            }
            if (Input.GetButtonDown(_fire2))
            {
                _missiles.Attack();
            }
        }
    }
}
