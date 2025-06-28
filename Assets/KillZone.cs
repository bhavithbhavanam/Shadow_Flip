using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player fell! Restarting...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
