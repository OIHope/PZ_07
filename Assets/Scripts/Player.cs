using UnityEngine;

public class Player : Person
{
    [SerializeField] private int _experience;
    [SerializeField][Range(0,5)] private float moveSpeed;

    public int Experience
    {
        get
        {
            return _experience;
        }
        private set
        {
            _experience = value;
        }
    }
    public override void ShowStat()
    {
        base.ShowStat();
        Debug.Log($"{Name} has {_experience} EXP");
    }

    public override void TakeDamage(int damageValue)
    {
        Health -= damageValue;
        Debug.Log($"My name is {Name}, I've been dealt {damageValue} DMG, and now I have {Health} HP!");
    }
}
