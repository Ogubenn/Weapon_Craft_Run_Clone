using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;
    [Range(0f,5f)]
    public float fireRate = 0.5f; // Ateþ etme aralýðý
    public float DestroyBullet = 2f;

    private float nextFireTime = 0f; // Bir sonraki ateþ zamaný

    void Update()
    {
        if (Time.time >= nextFireTime)
        {
            //Time.time oyun baþladýktan sonra geçen süreyi saniye cinsinden belirtir.
            Fire();
            nextFireTime = Time.time + fireRate;
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);//UInstantiate parametreleri neyi oluþturcaðýmýz,positionu ve rotationu.
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * bulletSpeed, ForceMode.Impulse);//Impulse nesneye anlýk olarak kuvvet uygular.
        Destroy(bullet, DestroyBullet);

        /*"Instantiate", Unity oyun motorunda yeni bir nesne veya öðe oluþturmak için kullanýlan bir fonksiyondur. Bu fonksiyon, prefabslarýn oluþturur ve bu kopyayý sahneye veya hiyerarþiye ekler.*/
    }
}