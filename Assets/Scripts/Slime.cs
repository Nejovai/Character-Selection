namespace Enemy
{
    public class Slime : Enemies
    {
        protected override string Health()
        {
            return "� ���� ��� ��������, ������ ���� ��������.";
        }

        protected override string Attack()
        {
            return base.Attack() + " ����� �������.";
        }

    }
}
