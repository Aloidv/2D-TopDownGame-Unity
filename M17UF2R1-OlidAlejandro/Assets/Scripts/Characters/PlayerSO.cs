using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "ScriptableObject/Player")]
public class PlayerSO : CharacterSO
{
    public int Coins = 0;
    public int EnemiesDefeated = 0;
    public float DashCooldown = 3;
    public float DashDuration = 0.5f;
    public float DashVelocity = 10;
    public float DefaultVelocity;
    public bool isDashing = false;
    public bool isPurchasing = false;
}
