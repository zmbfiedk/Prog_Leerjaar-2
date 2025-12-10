using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;

    void Start()
    {
        ScoreSystem.Instance.onScoreChanged += UpdateScoreUI;
    }

    void OnDestroy()
    {
        ScoreSystem.Instance.onScoreChanged -= UpdateScoreUI; // verplicht bij delegates!
    }

    void UpdateScoreUI(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
