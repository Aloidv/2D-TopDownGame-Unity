using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBulletController : MonoBehaviour
{
    [SerializeField]
    Bullet Bullet;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = Bullet.GetSprite();
        transform.localScale *= Bullet.GetSize();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<EnemyController>().TakeDamage(Bullet.GetDamage());
        }

        if (collision.CompareTag("LootBox"))
        {
            Destroy(collision.gameObject);
        }

        if (!collision.CompareTag("WeaponHolder") && !collision.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
