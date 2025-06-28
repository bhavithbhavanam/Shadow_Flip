using UnityEngine;

public class Collectible : MonoBehaviour
{
    void Start()
    {
        ScoreManager.RegisterCoin(); // Increases totalCoins at start
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddScore(1); // Adds to visible score
            Destroy(gameObject);
        }
    }
}
