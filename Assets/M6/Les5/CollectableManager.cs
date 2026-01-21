using System.Collections.Generic;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    public static CollectibleManager Instance;

    private List<Collectable> collectibles = new List<Collectable>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        collectibles.AddRange(FindObjectsOfType<Collectable>());
        Debug.Log("Total collectibles: " + collectibles.Count);
    }

    public void Collect(Collectable collectable)
    {
        collectibles.Remove(collectable);
        Debug.Log("Collectible collected! Remaining: " + collectibles.Count);
    }
}
