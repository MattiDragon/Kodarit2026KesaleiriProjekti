using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int coins = 0;
    public int maxCoins;
    public TMPro.TextMeshProUGUI coinText;

    public void AddCoin()
    {
        coins++;
        coinText.text = "Coins: " + coins;

        if (coins >= maxCoins)
        {
            Time.timeScale = 0;
        }
    }
}
