using UnityEngine;
using UnityEngine.SceneManagement;

public class TunnelToNextLevel : MonoBehaviour
{
    public string nextSceneName = "Level3"; // Name of your final level scene

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (ScoreManager.score >= 18)  // all coins collected
            {
                SceneManager.LoadScene(nextSceneName);
            }
            else
            {
                Debug.Log("Collect all 18 coins to enter the tunnel!");
            }
        }
    }
}
