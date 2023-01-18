using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletController : MonoBehaviour
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
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().TakeDamage(Bullet.GetDamage());
        }

        if (!collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
