using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;
    public float shootCooldown = 0.5f;
    private float lastShotTime;
    private int currentBullets;
    public int BulletLifetime = 20;
    public int maxBullets = 10;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= lastShotTime + shootCooldown)
        {
            Shoot();
            Shoot();
            Shoot();
            lastShotTime = Time.time;
        }
    }

    void Shoot()
    {
        if (currentBullets < maxBullets)
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.velocity = firePoint.right * bulletSpeed;
            currentBullets++;

            Destroy(bullet, BulletLifetime); // Clean up bullet after 5 seconds
            StartCoroutine(DecreaseBulletCountAfterDelay(BulletLifetime));
        }
    }

    IEnumerator DecreaseBulletCountAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        currentBullets--;
    }
}