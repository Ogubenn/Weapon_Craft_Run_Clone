using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    [Range(0f,5f)]
    public float fireRate = 0.5f; // Ate� etme aral���
    public float DestroyBullet = 2f;

    private float nextFireTime = 0f; // Bir sonraki ate� zaman�

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            //Time.time oyun ba�lad�ktan sonra ge�en s�reyi saniye cinsinden belirtir.
            Fire();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//UInstantiate parametreleri neyi olu�turca��m�z,positionu ve rotationu.
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse);//Impulse nesneye anl�k olarak kuvvet uygular.
        Destroy(bullet, DestroyBullet);

        /*"Instantiate", Unity oyun motorunda yeni bir nesne veya ��e olu�turmak i�in kullan�lan bir fonksiyondur. Bu fonksiyon, prefabslar�n olu�turur ve bu kopyay� sahneye veya hiyerar�iye ekler.*/
    }
}