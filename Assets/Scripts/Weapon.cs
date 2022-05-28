using UnityEngine;

namespace SpacePatterns
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Weapon : MonoBehaviour, IAttack
    {

        protected Rigidbody _weapon;
        protected Transform _barrel;
        protected float _force = 10f;
        private IAmmunition _bullet;

        public Weapon(Rigidbody weapon, Transform barrel, float force)
        {
            _weapon = weapon;
            _barrel = barrel;
            _force = force;
        }
        public void Attack()
        {
            if (!LockShooting.CantShoot)
            {
                Object.Instantiate(_weapon, _barrel.position, _barrel.rotation);
                _weapon.AddForce(Vector3.forward * _force);
            }
        }

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrel = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        public void SetForce(float force)
        {
            _force = force;
        }
    }
}