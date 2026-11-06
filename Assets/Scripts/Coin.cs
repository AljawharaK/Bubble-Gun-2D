using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int value = 1; // القيمة الافتراضية للعملة
    private bool hasTriggered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            if (CoinManager.instance != null)
            {
                CoinManager.instance.ChangeCoins(value);
            }
            Destroy(gameObject);
        }
    }
}
