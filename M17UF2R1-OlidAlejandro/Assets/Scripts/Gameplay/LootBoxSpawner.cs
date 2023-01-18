using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBoxSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject LootBoxedPrefab;

    [SerializeField]
    List<GameObject> LootBoxesSpawned = new List<GameObject>();

    [SerializeField]
    Transform[] spawnLocation;

    [SerializeField]
    float spawnInterval;
    
    float spawnTimer;
    int spawnIndex;

    void FixedUpdate()
    {
        spawnTimer -= Time.fixedDeltaTime;
        if (spawnTimer <= 0 && LootBoxesSpawned.Count < spawnLocation.Length)
        {

            GameObject lootBox = Instantiate(LootBoxedPrefab, spawnLocation[GetSpawnIndex()].position, Quaternion.identity);
            LootBoxesSpawned.Add(lootBox);
            spawnTimer = spawnInterval;
        }

        ClearPrefabsList();
    }

    //reset de la lista para no colapsar los spawns
    void ClearPrefabsList()
    {
        if (GameObject.FindGameObjectWithTag("LootBox") == null)
        {
            LootBoxesSpawned.Clear();
        }
    }

    int GetSpawnIndex()
    {
        if (spawnIndex + 1 <= spawnLocation.Length - 1)
        {
            spawnIndex++;
        }
        else
        {
            spawnIndex = 0;
        }

        return spawnIndex;
    }
}
