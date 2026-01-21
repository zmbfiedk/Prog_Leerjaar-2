using UnityEngine;

public class Zombie : Enemy
{
    private void Start()
    {
        gameObject.name = "Zombie";
        health = 100f;
    }

    public override void TakeDamage(float damage)
    {
        float reducedDamage = damage * 0.8f;
        health -= reducedDamage;

        Debug.Log($"Zombie krijgt {reducedDamage} damage! HP: {health}");

        if (health <= 0)
        {
            Die();
        }
    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Zombie bijt {target.name}!");
    }
}
