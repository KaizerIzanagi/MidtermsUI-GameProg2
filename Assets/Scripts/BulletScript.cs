using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public enum ColorBullet
{
    red,
    yellow,
    black
}

public class BulletScript : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bulletPrefab;
    public float bulletSpeed, bulletFireRate, baseFireRate;
    public ColorBullet colors;

    void Start()
    {
        baseFireRate = bulletFireRate;
    }

    void Update()
    {
        bulletFireRate -= Time.deltaTime;
        if (bulletFireRate <= 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
        Rigidbody rigidBullet = bullet.GetComponent<Rigidbody>();
        rigidBullet.AddForce(bulletSpawn.forward * bulletSpeed, ForceMode.Impulse);
        bulletFireRate = baseFireRate;
    }
}
