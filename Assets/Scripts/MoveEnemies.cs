using UnityEngine;

namespace SpacePatterns
{
    internal class MoveEnemies : IEnemyMove
    {
        private float _moveSpace = 2f;
        private EnemyShip _enemyShip;

        public MoveEnemies(EnemyShip enemyShip)
        {
            _enemyShip = enemyShip;
            EnemyMove();
        }

        public void EnemyMove()
        {
            _enemyShip.transform.Translate(new Vector3(Random.Range(-_moveSpace, _moveSpace), Random.Range(-_moveSpace, _moveSpace), 0));
        }
    }
}   