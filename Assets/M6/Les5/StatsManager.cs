using UnityEngine;
using TMPro;

public class StatsManager : MonoBehaviour
{
    public static StatsManager Instance;

    [Header("Stats")]
    public int health = 100;
    public int score = 0;

    [Header("UI")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        UpdateUI();
    }

    public void AddHealth(int amount)
    {
        health += amount;
        health = Mathf.Clamp(health, 0, 100);
        UpdateUI();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        healthText.text = "Health: " + health;
        scoreText.text = "Score: " + score;
    }
}
