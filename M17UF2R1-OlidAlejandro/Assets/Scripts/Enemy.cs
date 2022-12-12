using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    [SerializeField]
    int cost;

    [SerializeField]
    GameObject enemyPrefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
