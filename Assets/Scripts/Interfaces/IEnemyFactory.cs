using UnityEngine;

namespace SpacePatterns
{
    internal interface IEnemyFactory
    {
      public Enemy Create(Health hp);
    }
}
