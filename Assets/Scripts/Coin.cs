using UnityEngine;

public class Coin : MonoBehaviour
{
    // Viittaus scenen GameManager-objektiin
    public GameManager gameManager;


    // Kun pelihahmo osuu kolikkoon
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Kerrotaan GameManagerille, että kolikko on kerätty
        gameManager.AddCoin();
        // Poistetaan kolikko-objekti scenestä
        Destroy(gameObject);
    }
}
