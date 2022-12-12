using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
        public List<Enemy> enemies = new List<Enemy>();
        public int currWave;
        private int waveValue;
        public List<GameObject> enemiesToSpawn = new List<GameObject>();

        public Transform[] spawnLocation;
        public int spawnIndex;

        public int waveDuration;
        private float waveTimer;
        private float spawnInterval;
        private float spawnTimer;

        public List<GameObject> spawnedEnemies = new List<GameObject>();

        void Start()
        {
            GenerateWave();
        }

        void FixedUpdate()
        {
            if (spawnTimer <= 0)
            {
                if (enemiesToSpawn.Count > 0)
                {
                    GameObject enemy = (GameObject)Instantiate(enemiesToSpawn[0], spawnLocation[spawnIndex].position, Quaternion.identity); // spawn first enemy in our list
                    enemiesToSpawn.RemoveAt(0); // and remove it
                    spawnedEnemies.Add(enemy);
                    spawnTimer = spawnInterval;

                    if (spawnIndex + 1 <= spawnLocation.Length - 1)
                    {
                        spawnIndex++;
                    }
                    else
                    {
                        spawnIndex = 0;
                    }
                }
                else
                {
                    waveTimer = 0; 
                }
            }
            else
            {
                spawnTimer -= Time.fixedDeltaTime;
                waveTimer -= Time.fixedDeltaTime;
            }

            if (waveTimer <= 0 && spawnedEnemies.Count <= 0)
            {
                currWave++;
                GenerateWave();
            }
        }

        public void GenerateWave()
        {
            waveValue = currWave * 10;
            GenerateEnemies();

            spawnInterval = waveDuration / enemiesToSpawn.Count; // gives a fixed time between each enemies
            waveTimer = waveDuration; // wave duration is read only
        }

        public void GenerateEnemies()
        {
            // Create a temporary list of enemies to generate
            // 
            // in a loop grab a random enemy 
            // see if we can afford it
            // if we can, add it to our list, and deduct the cost.

            // repeat... 

            //  -> if we have no points left, leave the loop

            List<GameObject> generatedEnemies = new List<GameObject>();
            while (waveValue > 0 || generatedEnemies.Count < 50)
            {
                int randEnemyId = Random.Range(0, enemies.Count);
                int randEnemyCost = enemies[randEnemyId].GetCost();

                if (waveValue - randEnemyCost >= 0)
                {
                    generatedEnemies.Add(enemies[randEnemyId].GetEnemyPrefab());
                    waveValue -= randEnemyCost;
                }
                else if (waveValue <= 0)
                {
                    break;
                }
            }
            enemiesToSpawn.Clear();
            enemiesToSpawn = generatedEnemies;
        }
}
