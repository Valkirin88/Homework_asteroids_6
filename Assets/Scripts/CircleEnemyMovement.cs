using UnityEngine;

namespace SpacePatterns
{
    internal class CircleEnemyMovement : IEnemyMove
    {
        private EnemyShip _enemyShip;
        [SerializeField] private float angle = 1;
        [SerializeField] private float radius = 0.5f;
        [SerializeField] private float speed = 1.0f;

        public CircleEnemyMovement(EnemyShip enemyShip)
        {
            _enemyShip = enemyShip;
            EnemyMove();
        }

        public void EnemyMove()
        {
            angle += Time.deltaTime; 
            var x = Mathf.Cos(angle * speed) * radius;
            var y = Mathf.Sin(angle * speed) * radius;
            _enemyShip.transform.position = new Vector2(x, y);
        }
    }
}
