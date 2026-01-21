using UnityEngine;

public class HealthPickup : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        StatsManager.Instance.AddHealth(20);
        Debug.Log("Health restored!");
    }
}
