namespace 1_Initial_Program
{

    public interface IAttackble{};

    public class Ninja : IAttackble
    {

        public AttackResult Attack(IAttackble target)
        {

            if(IsCloseRange(target))
            {
                return new AttackResult(new Sword(), 
                    this, target);

            }
            else
            {
                return now AttackResult(new Shuriken(), 
                    this, target);
            }
        }
    }
}