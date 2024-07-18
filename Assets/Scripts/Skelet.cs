using UnityEngine;

namespace Enemy
{
    public class Skelet : Enemies
    {
        [SerializeField] private bool isNearAttack;


        protected override string Attack()
        {
            if (!isNearAttack)
                return $"{base.Attack()}\n\n����� ����� ��������, �� �������� ������ ������.\n(���� �� � ������)";

            else
                return $"{base.Attack()}\n\n����� ������������� �� ����. �� ����� ���������.";
        }
    }
}
