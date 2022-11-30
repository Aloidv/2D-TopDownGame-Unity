using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int AttackVelocity = 10;
    public int AttackCooldown = 10;
    public Bullet Bullet;
    public int Size = 1;
    public Vector2 BulletDirection;

    void Start()
    {
        
    }

    void Update()
    {
        BulletDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Shoot();
    }

    internal void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(Bullet, transform.position, Quaternion.identity);
        }
    }
}
