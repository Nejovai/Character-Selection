using UnityEngine;

namespace Enemy
{
    public class Skelet : Enemies
    {
        [SerializeField] private bool isNearAttack;


        protected override string Attack()
        {
            if (!isNearAttack)
                return $"{base.Attack()}\n\nХотел стать лучником, но остались только посохи.\n(Зато не в пехоте)";

            else
                return $"{base.Attack()}\n\nЧасто промахивается по цели. Но очень старается.";
        }
    }
}
