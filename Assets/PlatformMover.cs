using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed = 2f;

    private bool movingToB = true;

    void Update()
    {
        Vector3 target = movingToB ? pointB : pointA;
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target) < 0.1f)
        {
            movingToB = !movingToB;
        }
    }
}
