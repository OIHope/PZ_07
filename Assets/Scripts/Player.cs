using Assets.Scripts;
using UnityEngine;

public class Player : Person
{
    [SerializeField] private int _experience;
    [SerializeField][Range(0, 5)] private float moveSpeed;
    [SerializeField] private Person dragon;

    private void Update() => Move();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy") TakeDamage(dragon.Damage);
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
            transform.Translate(-1 * (moveSpeed * Time.deltaTime), 0, 0);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(1 * (moveSpeed * Time.deltaTime), 0, 0);
    }
    public int Experience
    {
        get => _experience;
        private set => _experience = value;
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
