using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime); // Destroy bullet after 5 seconds
    }

    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime); // Move left
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reset level
        }
    }
}
