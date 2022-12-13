using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    [SerializeField]
    Bullet Bullet;
    
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = Bullet.GetSprite();
        transform.localScale *= Bullet.GetSize();
    }

    public Bullet GetBullet()
    {
        return Bullet;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Bullet.GetName() == "EnemyBullet")
        {
            collision.GetComponent<Player>().TakeDamage(Bullet.GetDamage());
        }

        if (collision.CompareTag("Enemy") && Bullet.GetName() != "EnemyBullet")
        {
            Destroy(collision);
        }

        Destroy(gameObject);
    }
}
