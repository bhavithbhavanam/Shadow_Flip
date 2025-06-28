using UnityEngine;
using UnityEngine.SceneManagement;

public class CrawlingZombie : MonoBehaviour
{
    public Vector2 pointA;         // Start point (enter in Inspector)
    public Vector2 pointB;         // End point (enter in Inspector)
    public float speed = 2f;

    private Vector2 target;

    void Start()
    {
        transform.position = pointA;
        target = pointB;
    }

    void Update()
    {
        // Move zombie toward target point
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);

        // If reached target, switch direction
        if (Vector2.Distance(transform.position, target) < 0.05f)
        {
            target = target == pointA ? pointB : pointA;
            Flip();
        }
    }

    void Flip()
    {
        // Flip sprite on X-axis
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart level on touch
        }
    }
}
