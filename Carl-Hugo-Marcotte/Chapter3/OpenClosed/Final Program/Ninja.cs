namespace Final_Program
{

    public interface IAttackble{};

    public class Ninja : IAttackble
    {
        public Weapon EquippedWeapon{get; set;}

        public AttackResult Attack(IAttackble target)
        {
            throw new NotImplementedException();
        }
    }
}