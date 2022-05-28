using UnityEngine;

namespace SpacePatterns
{
    public interface IAmmunition
    {
        Rigidbody BulletInstance { get; }
        float TimeToDestroy { get; }
    }
}
