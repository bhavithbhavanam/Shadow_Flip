using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterPlant : MonoBehaviour
{
    public float riseHeight = 1.5f;       // How high the plant moves up
    public float speed = 2f;              // Movement speed
    public float waitTime = 1.5f;         // Time it stays up/down

    private Vector3 startPos;
    private bool goingUp = true;
    private float waitTimer = 0f;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (waitTimer > 0)
        {
            waitTimer -= Time.deltaTime;
            return;
        }

        Vector3 targetPos = goingUp ? startPos + Vector3.up * riseHeight : startPos;
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, targetPos) < 0.01f)
        {
            goingUp = !goingUp;
            waitTimer = waitTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Restart level
        }
    }
}
