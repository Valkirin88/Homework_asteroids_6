
namespace SpacePatterns
{
    internal sealed class EnemyShip : Enemy
    {
        private readonly IAttack _attack;
        private readonly IEnemyMove _enemyMove;

        public EnemyShip(IAttack attack, IEnemyMove enemyMove)
        {
            _attack = attack;
            _enemyMove = enemyMove;
        }

        public void Attack()
        {
            _attack.Attack();
        }

        public void EnemyMove()
        {
            _enemyMove.EnemyMove();
        }

        public override string ToString()
        {
            return $"Speed {Speed} Health {Health}";
        }
    }
}