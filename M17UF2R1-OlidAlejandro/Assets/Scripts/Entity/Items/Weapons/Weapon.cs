using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int AttackVelocity;
    public int AttackCooldown;
    public Bullet Bullet;
    public int Size;
    public Vector2 BulletDirection;

    void Start()
    {
        
    }

    void Update()
    {
        BulletDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
}
