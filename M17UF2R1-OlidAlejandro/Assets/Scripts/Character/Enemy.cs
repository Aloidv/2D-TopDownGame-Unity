using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField]
    internal int cost;

    [SerializeField]
    internal GameObject enemyPrefab;

    internal GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Movement();
    }

    internal void Movement()
    {
        GetComponent<Rigidbody2D>().velocity = InputDirection() * Velocity;
    }

    internal Vector3 InputDirection()
    {
        Vector3 playerPosition = player.transform.position;
        Vector3 direction = playerPosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);
        return direction.normalized;
    }

    public int GetCost()
    {
        return cost;
    }

    public GameObject GetEnemyPrefab()
    {
        return enemyPrefab;
    }

    public void Dying()
    {
        GetComponent<LootBox>().DropLot();
        Destroy(gameObject);
    }

}
