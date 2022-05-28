using UnityEngine;

namespace SpacePatterns
{
    internal sealed class EnemyShipFactory : IEnemyFactory
    {
        private const string _enemyShip = "Enemies/EnemyShip";
        private GetRandomPosition _getRandomPosition;
        
        public Enemy Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<EnemyShip>(_enemyShip), new GetRandomPosition().GetPosition(), Quaternion.identity);
            enemy.DependencyInjectionHealth(hp);
            return enemy;
        }
    }
}
