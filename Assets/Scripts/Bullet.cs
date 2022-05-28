using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Bullet : Weapon, IAttack
    {
        public Bullet(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {

        }
    }
}
