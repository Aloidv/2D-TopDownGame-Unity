using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "ScriptableObject/Enemy")]
public class EnemySO : CharacterSO
{
    public int cost;
    public GameObject enemyPrefab;
    public int EnemyDamage = 10;
}
