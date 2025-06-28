using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float moveDistance = 3f;
    public float speed = 2f;

    private Vector3 startPos;
    private bool movingRight = true;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * speed, moveDistance);
        transform.position = startPos + new Vector3(offset, 0f, 0f); // For side-to-side movement
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Restart scene on contact
            UnityEngine.SceneManagement.SceneManager.LoadScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex
            );
        }
    }
}
