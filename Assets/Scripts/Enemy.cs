using UnityEngine;

namespace SpacePatterns
{
    internal abstract class Enemy : MonoBehaviour
    {
        public const string _asteroid = "Enemies/Asteroid";
        public const string _enemyShip = "Enemies/EnemyShip";
        public static IEnemyFactory Factory;
        public float Speed;
        public Health Health { get; private set; }
       

        public static Asteroid CreateAsteroidEnemy (Health hp)
        {
            var enemy = Instantiate(Resources.Load<Asteroid>(_asteroid), new GetRandomPosition().GetPosition(), Quaternion.identity);
            enemy.Health = hp;
            return enemy;
        }

        public static EnemyShip CreateEnemyShip (Health hp)
        {
            var enemy = Instantiate(Resources.Load<EnemyShip>(_enemyShip), new GetRandomPosition().GetPosition(), Quaternion.identity);
            enemy.Health = hp;
            return enemy;
        }

        public void DependencyInjectionHealth(Health hp)
        {
            Health = hp;
        }
    }
}
