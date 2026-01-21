using UnityEngine;

public class Troll : Enemy
{
    private float regenRate = 5f;

    private void Start()
    {
        gameObject.name = "Troll";
        health = 150f;
    }

    private void Update()
    {
        if (health > 0 && health < 150f)
        {
            health += regenRate * Time.deltaTime;
        }
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log("Troll slaat keihard met zijn knuppel!");
    }

    public override void TakeDamage(float damage)
    {
        Debug.Log("Troll gromt en regenereert langzaam...");
        base.TakeDamage(damage);
    }
}
