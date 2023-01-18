using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorretController : EnemyController
{
    public TorretSO TorretSO;
    float counterCooldown = 0;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        InputDirection();
        Shoot();
    }

    public void Shoot()
    {
        counterCooldown += Time.deltaTime;
        if (counterCooldown >= TorretSO.ShootCoolDown)
        {
            Instantiate(TorretSO.BulletPrefab, transform.position, Quaternion.identity)
                .GetComponent<Rigidbody2D>()
                .AddForce(InputDirection() * TorretSO.Bullet.GetVelocity(), ForceMode2D.Impulse);
            counterCooldown = 0;
        }
    }
}
