namespace Final_Program
{

    public interface IAttackble{};

    public AttackResult Attack(IAttackble target)
    {
        return new AttackResult(EquippedWeapon, this, target);
    }

    public class Ninja : IAttackble
    {
        public Weapon EquippedWeapon{get; set;}

        public AttackResult Attack(IAttackble target)
        {
            throw new NotImplementedException();
        }
    }
}