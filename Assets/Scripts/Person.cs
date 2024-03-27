using UnityEngine;

public abstract class Person : MonoBehaviour
{
    [SerializeField] private string _name = string.Empty;
    [Space(10)]
    [SerializeField] private int _health;

    public string Name { get { return _name; } private set { _name = value; } }
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            if (value < 0)
            {
                _health = 0;
                Debug.Log("Health value is lower then 0 !");
            }
            else if (value > 100)
            {
                _health = 100;
                Debug.Log("Health value is more then 100 !");
            }
            _health = value;
        }
    }
    public virtual void ShowStat()
    {
        Debug.Log($"Name is {_name}");
    }
    public abstract void TakeDamage(int damageValue);
}
