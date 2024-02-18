using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    [Range(0f, 5f)]
    public float fireRate = 0.5f;
    public float swapFireRate = 0f;
    public float DestroyBullet = 2f;
    public FireRateGate fireRateScript;


    private float nextFireTime = 0f;


    void Update()
    {
        if (Time.time >= nextFireTime)
        {

            Fire();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(bullet, DestroyBullet);
    }
    public void FireRate›ncrase()
    {
        if (fireRateScript.FireRate›ncreasedNumber == 1)
        {
            swapFireRate += 0.01f;

        }
        if (fireRateScript.FireRate›ncreasedNumber == 5)
        {
            swapFireRate += 0.05f;

        }
    }

    public void FireRateUpdate()
    {
        fireRate = fireRate - swapFireRate;
    }
}