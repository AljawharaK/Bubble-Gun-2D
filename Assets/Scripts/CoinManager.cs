using UnityEngine;
using TMPro;

public class CoinManager : MonoBehaviour
{
    public static CoinManager instance;
    private int coins;
    [SerializeField] private TMP_Text coinsDisplay;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void ChangeCoins(int amount)
    {
        coins += amount;
        UpdateCoinsDisplay(); // تحديث النص فورًا
    }

    private void UpdateCoinsDisplay()
    {
        if (coinsDisplay != null)
        {
            coinsDisplay.text = coins.ToString();
        }
    }
}
