using UnityEngine;
using System;

public class ScoreSystem : MonoBehaviour
{
    public static ScoreSystem Instance;

    public int score;

    // Delegate die lijsten van functies kan vasthouden
    public delegate void ScoreChanged(int newScore);
    public ScoreChanged onScoreChanged;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore(int amount)
    {
        score += amount;

        // Delegate triggeren
        if (onScoreChanged != null)
            onScoreChanged(score);
    }
}
