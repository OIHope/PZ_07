using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [SerializeField] private string _name = string.Empty;
    [Space(10)]
    [SerializeField] private int _health;
    [SerializeField] private int _damage;

    public string Name { get { return _name; } private set { _name = value; } }
    public int Health
    {
        get => _health;
        set
        {
            if (value < 0)
            {
                value = 0;
                Debug.Log("Health value is lower then 0 ! This obj is dead");
                Destroy(this);
            }
            else if (value > 100)
            {
                value = 100;
                Debug.Log("Health value is more then 100 !");
            }
            _health = value;
        }
    }
    public int Damage
    {
        get => _damage;
        private set
        {
            if (value < 0)
            {
                _damage = 0;
                Debug.Log("Damage value is lower then 0 !");
            }
            _damage = value;
        }
    }
    public virtual void ShowStat() => Debug.Log($"Name is {_name}");
    public abstract void TakeDamage(int damageValue);
}
