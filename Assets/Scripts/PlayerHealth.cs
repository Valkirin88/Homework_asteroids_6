using UnityEngine;

namespace SpacePatterns
{
    internal sealed class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private float _hp = 10;
        private LockShooting _lockShooting;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.GetComponent<Weapon>())
            {
                if (_hp <= 0)
                {
                    Destroy(gameObject);
                }
                else
                {
                    _hp--;
                }
            }
            else if (collision.gameObject.GetComponent<ILockShoot>() != null)
            {
                _lockShooting = new LockShooting();
                _lockShooting.GetLocked();
            }
        }
    }
}
