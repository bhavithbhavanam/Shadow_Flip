using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 2f;

    private float fireTimer = 0f;

    void Update()
    {
        fireTimer += Time.deltaTime;

        if (fireTimer >= fireRate)
        {
            fireTimer = 0f;
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
    }
}
