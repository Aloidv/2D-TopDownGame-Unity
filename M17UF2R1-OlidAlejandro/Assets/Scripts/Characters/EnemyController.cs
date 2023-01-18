using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public EnemySO EnemySO;
    public PlayerController player;
    float currentHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        currentHealth = EnemySO.MaxHealth;
    }

    void Update()
    {
        Movement();
    }

    internal void Movement()
    {
        GetComponent<Rigidbody2D>().velocity = InputDirection() * EnemySO.Velocity;
    }

    internal Vector3 InputDirection()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 direction = playerPosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
        return direction.normalized;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        CheckDeath();
    }

    void CheckDeath()
    {
        if (currentHealth <= 0)
        {
            Dying();
        }

    }

    void Dying()
    {
        GetComponent<LootBoxPrefab>().DropLot();
        player.EnemyDefeated();
        Destroy(gameObject);
    }
}
