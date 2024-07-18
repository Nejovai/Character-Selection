namespace Enemy
{
    public class Slime : Enemies
    {
        protected override string Health()
        {
            return "У него нет здоровья, только срок годности.";
        }

        protected override string Attack()
        {
            return base.Attack() + " Любит листики.";
        }

    }
}
