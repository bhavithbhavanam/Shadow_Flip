using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeTrap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player died! Restarting level...");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
