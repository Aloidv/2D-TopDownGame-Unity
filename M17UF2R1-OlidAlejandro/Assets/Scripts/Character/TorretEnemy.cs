using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretEnemy : Enemy
{
    [SerializeField]
    float ShootCoolDown = 2;

    [SerializeField]
    GameObject Prefab;

    [SerializeField]
    Bullet Bullet;

    float counterCooldown = 0;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        InputDirection();
        Shoot();
    }

    public void Shoot()
    {
        counterCooldown += Time.deltaTime;
        if (counterCooldown >= ShootCoolDown)
        {
            Instantiate(Prefab, transform.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>()
                .AddForce(InputDirection() * Bullet.GetVelocity(), ForceMode2D.Impulse);
            counterCooldown = 0;
        }
    }
}
