 using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Missiles : Weapon, IAttack
    {
        public Missiles(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {
            
        }
    }
}
