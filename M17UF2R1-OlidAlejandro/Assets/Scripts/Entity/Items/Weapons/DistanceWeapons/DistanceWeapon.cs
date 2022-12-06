using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceWeapon : Weapon
{
    [SerializeField]
    internal Bullet Bullet;

    [SerializeField]
    internal Vector2 BulletDirection;

    [SerializeField]
    internal int GunMagazine; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    internal override void Attack()
    {
        Debug.Log("piu piuuuuuuuuuu");
        Bullet bullet = Instantiate(Bullet, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().AddForce(transform.up * bullet.BulletVelocity, ForceMode2D.Impulse);
    }
}
