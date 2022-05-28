using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Laser : Weapon, IAttack
    {
        public Laser(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {

        }
    }
}
