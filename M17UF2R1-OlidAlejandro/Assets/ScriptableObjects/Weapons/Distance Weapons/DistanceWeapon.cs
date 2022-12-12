using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Distance Weapon", menuName = "ScriptableObject/Distance Weapon")]
public class DistanceWeapon : Weapon
{
    [SerializeField]
    Bullet Bullet;

    [SerializeField]
    int DefaultNumBullets = 10;

    [SerializeField]
    int NumBullets = 10;

    public override void Attack(Transform transform)
    {
        if (NumBullets > 0)
        {
            NumBullets--;
            Instantiate(Bullet, transform.position, Quaternion.identity)
            .GetComponent<Rigidbody2D>()
            .AddForce(transform.right * Bullet.GetBulletVelocity(), ForceMode2D.Impulse);
        }
        else
        {
            Reloading();
        }
    }

    void Reloading()
    {
        Debug.Log("estoy recargando/meter animacion y tiempo");
        NumBullets = DefaultNumBullets;
    }
}
