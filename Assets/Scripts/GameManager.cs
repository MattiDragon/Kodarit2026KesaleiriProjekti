using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Kerättyjen kolikoiden määrä
    public int coins = 0;

    // Kerättävät kolikko-objektit
    public GameObject[] coinObjects;

    // Teksti, joka näyttää kerätyt kolikot
    public TMPro.TextMeshProUGUI coinText;

    // Kun kolikko kerätään
    public void AddCoin()
    {
        // Kasvattaa kerättyjen kolikoiden määrää
        coins++;
        // Päivittää tekstin
        coinText.text = "Coins: " + coins.ToString();
        // Pysäyttää pelin, kun kaikki kolikot on kerätty
        if (coins >= coinObjects.Length)
        {
            Time.timeScale = 0;
        }
    }
}
