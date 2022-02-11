namespace Final_Program
{
    public class AttackResult
    {
        
        public Weapon weapon{get; }
        public IAttackble Attacker{get; }
        public IAttackble Target{get; }

        public AttackResult(Weapon weapon, IAttackble attacker, 
            IAttackble target)
            {
                Weapon = weapon;
                Attacker = attacker;
                Target = target;
            }
    }
}


