using UnityEngine;

public class DamageTrap : Collectable
{
    public override void OnCollect(GameObject collector)
    {
        StatsManager.Instance.AddHealth(-5);
        Debug.Log("BOOM!!");
    }
}
