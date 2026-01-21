using UnityEngine;

public abstract class Collectable : MonoBehaviour
{
    public abstract void OnCollect(GameObject collector);

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        OnCollect(other.gameObject);

        CollectibleManager.Instance.Collect(this);

        Destroy(gameObject);
    }
}
