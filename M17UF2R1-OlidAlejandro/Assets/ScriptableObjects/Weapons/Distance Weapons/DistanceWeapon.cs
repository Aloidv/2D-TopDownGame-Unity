using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Distance Weapon", menuName = "ScriptableObject/Distance Weapon")]
public class DistanceWeapon : Weapon
{
    [SerializeField]
    BulletPrefab Prefab;

    [SerializeField]
    int DefaultNumBullets = 10;

    [SerializeField]
    int CurrentNumBullets = 10;

    [SerializeField]
    int TotalNumBullets = 10;

    [SerializeField]
    int MaxNumBullets = 100;

    public override void Attack(Transform transform)
    {
        if (CurrentNumBullets > 0)
        {
            CurrentNumBullets--;
            Instantiate(Prefab, transform.position, Quaternion.identity)
            .GetComponent<Rigidbody2D>()
            .AddForce(transform.right * Prefab.GetBullet().GetVelocity(), ForceMode2D.Impulse);
        }
        else
        {
            Reloading();
        }
    }

    public override void TakeBullets()
    {
        TotalNumBullets += 20;
        if (TotalNumBullets > MaxNumBullets)
        {
            TotalNumBullets = MaxNumBullets;
        }
    }

    void Reloading()
    {
        Debug.Log("estoy recargando/meter animacion y tiempo");

        
        if (TotalNumBullets >= DefaultNumBullets) // Si tienes mas balas que el cargador, recarga de "n" en "n" (DefaultNumBullets)
        {
            CurrentNumBullets = TotalNumBullets - DefaultNumBullets;
            TotalNumBullets -= DefaultNumBullets;
        }
        else if (TotalNumBullets > CurrentNumBullets && TotalNumBullets < DefaultNumBullets) // Si tienes menos que un cargador pero tienes alguna, recarga las que tengas (TotalNumBullets)
        {
            CurrentNumBullets = TotalNumBullets;
            TotalNumBullets -= TotalNumBullets;
        }
        else
        {
            Debug.Log("no tengo balas");
        }
    }

}
