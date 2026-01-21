using UnityEngine;

public class CoinPickup : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        StatsManager.Instance.AddScore(10);
        Debug.Log("Coin collected!");
    }
}
