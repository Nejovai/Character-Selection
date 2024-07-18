using UnityEngine;

namespace Enemy
{
    public class Enemies : MonoBehaviour
    {
        [SerializeField] protected new string name;
        [SerializeField] protected int health;
        [SerializeField] protected string damage;
        [SerializeField] private bool canAttack;

        public string Name()
        {
            return name;
        }

        protected virtual string Attack()
        {
            if (canAttack)
                return $"Урон: {damage}";
            else return "Дружелюбен.";
        }

        protected virtual string Health()
        {
            return $"Здоровье: {health}";
        }

        public string Description()
        {
            return $"{Health()}\n\n{Attack()}";
        }
    }
}



