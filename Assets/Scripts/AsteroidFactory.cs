using UnityEngine;

namespace SpacePatterns
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        private const string _asteroid = "Enemies/Asteroid";
     public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<Asteroid>(_asteroid), new GetRandomPosition().GetPosition(), Quaternion.identity);
            enemy.DependencyInjectionHealth(hp);
            return enemy;
        }
    }
}
