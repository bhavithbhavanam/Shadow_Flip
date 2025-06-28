using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorUnlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (KeyPickup.hasKey)
            {
                Debug.Log("Door unlocked! Loading next level...");
                LoadNextLevel();
            }
            else
            {
                Debug.Log("Door is locked. Find the key.");
            }
        }
    }

    void LoadNextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            // Load next level
            SceneManager.LoadScene(currentSceneIndex + 1);
        }
        else
        {
            Debug.Log("You completed the final level!");
            // Optional: Reload first level or show end screen
            SceneManager.LoadScene(0);
        }

        KeyPickup.hasKey = false; // Reset key on level change
        WorldFlip.inShadow = false; // Reset world state
    }
}
