using UnityEngine;

namespace SpacePatterns
{
    public interface IMove 
    {
        float Speed { get; }
        void Move(float horizontal, float vertical, float delatTime);
    }
}
