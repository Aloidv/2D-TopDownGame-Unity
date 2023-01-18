using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public PlayerSO PlayerSO;
    public EnemySpawner EnemySpawner;
    public bool Win = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public void CheckVictory() 
    {
        Debug.Log(EnemySpawner.spawnedEnemies.Count);
        Debug.Log(PlayerSO.EnemiesDefeated);

        if (EnemySpawner.spawnedEnemies.Count == PlayerSO.EnemiesDefeated)
        {
            Win = true;
        }
    }

    public void CheckDefeat()
    {
        if (PlayerSO.CurrentHealth <= 0)
        {
            Win = false;
            SceneManager.LoadScene("Result");
        }
    }

    public void LoadResultScene()
    {
        SceneManager.LoadScene("Result");
    }

    public void ResetGame()
    {
        ResetPlayerStats();
        SceneManager.LoadScene("Dungeon");  
    }

    public void ResetPlayerStats()
    {
        PlayerSO.Coins = 0;
        PlayerSO.EnemiesDefeated = 0;
        PlayerSO.CurrentHealth = PlayerSO.MaxHealth;
        PlayerSO.DefaultVelocity = PlayerSO.Velocity;
    }
}
