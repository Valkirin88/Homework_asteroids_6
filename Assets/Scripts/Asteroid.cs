using System;

namespace SpacePatterns
{
    internal sealed class Asteroid : Enemy
    {
        public override string ToString()
        {
            return $"Speed {Speed} Health {Health}";
        }
    }
}
