using UnityEngine;

public class Collectables : MonoBehaviour
{
    [SerializeField] private int scoreValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreSystem.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}
