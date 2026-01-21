using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    [Header("Player Settings")]
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;

    [Header("Enemies")]
    private List<Enemy> enemies = new List<Enemy>();

    private void Start()
    {
        currentHealth = maxHealth;

        enemies = new List<Enemy>
        {
            new GameObject().AddComponent<Zombie>(),
            new GameObject().AddComponent<Goblin>(),
            new GameObject().AddComponent<Dragon>(),
            new GameObject().AddComponent<Troll>() 
        };
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PLAYER ATTACKS");

            foreach (Enemy enemy in enemies)
            {
                if (enemy != null)
                    enemy.Attack(gameObject);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("ENEMIES ATTACK PLAYER");

            TakeDamage(15f);

            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                if (enemies[i] == null)
                {
                    enemies.RemoveAt(i);
                }
                else
                {
                    enemies[i].TakeDamage(25f);
                }
            }

            CheckVictory();
        }
    }

    private void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log($"BattleManager krijgt {damage} damage! HP: {currentHealth}");

        if (currentHealth <= 0)
        {
            GameOver();
        }
    }

    private void CheckVictory()
    {
        if (enemies.Count == 0)
        {
            Debug.Log(" VICTORY! Alle enemies zijn verslagen!");
            enabled = false;
        }
    }

    private void GameOver()
    {
        Debug.Log(" GAME OVER! BattleManager is dood!");
        enabled = false;
    }
}
