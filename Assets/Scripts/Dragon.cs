using UnityEngine;

namespace Assets.Scripts
{
    public class Dragon : Person
    {
        public override void TakeDamage(int damageValue)
        {
            Health -= damageValue;
            Debug.Log($"I'm the mighty DRAGON! I've been dealt {damageValue} DMG, and now I have {Health} HP!");
        }
    }
}