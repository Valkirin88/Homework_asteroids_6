namespace SpacePatterns
{
    internal abstract class ModificationWeapon : IAttack
    {
        private Weapon _weapon;
        protected abstract Weapon AddModification(Weapon weapon);
        public void ApplyModification(Weapon weapon)
        {
            _weapon = AddModification(weapon);
        }
        public void Attack()
        {
            _weapon.Attack();
        }
    }
}
