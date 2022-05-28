using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Main : MonoBehaviour
    {
        private const string _player = "Player";
        private const string _spaceSkyBox = "Space";
        private void Awake()
        {
            GameObject player = Resources.Load<GameObject>(_player);
            Instantiate(player);
                
            Material skybox = Resources.Load<Material>(_spaceSkyBox);
            RenderSettings.skybox = skybox;
           
            Asteroid enemy = Instantiate(Resources.Load<Asteroid>("Enemies/Asteroid"), new GetRandomPosition().GetPosition(), Quaternion.identity );

            Enemy.CreateAsteroidEnemy(new Health(100f, 100f));
            Enemy.CreateEnemyShip(new Health(100f, 100f));

            IEnemyFactory factoryAsteroid = new AsteroidFactory();
            IEnemyFactory factoryEnemyShip = new AsteroidFactory();
            factoryAsteroid.Create(new Health(100f, 100f));
            factoryEnemyShip.Create(new Health(100f, 100f)); 
        }
    }
}
