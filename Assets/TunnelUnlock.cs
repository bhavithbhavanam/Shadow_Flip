using UnityEngine;
using UnityEngine.SceneManagement;

public class TunnelUnlock : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            if (ScoreManager.AllCoinsCollected())
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                Debug.Log("Collect all coins to unlock the tunnel!");
            }
        }
    }
}
