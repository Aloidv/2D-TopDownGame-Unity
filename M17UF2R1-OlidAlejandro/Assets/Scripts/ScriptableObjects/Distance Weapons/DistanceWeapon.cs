using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Distance Weapon", menuName = "ScriptableObject/Distance Weapon")]
public class DistanceWeapon : Weapon
{
    [SerializeField]
    Bullet Bullet;

    public override void Attack(Transform transform)
    {
        Instantiate(Bullet, transform.position, Quaternion.identity)
            .GetComponent<Rigidbody2D>()
            .AddForce(transform.right * Bullet.GetBulletVelocity(), ForceMode2D.Impulse);
    }
}
