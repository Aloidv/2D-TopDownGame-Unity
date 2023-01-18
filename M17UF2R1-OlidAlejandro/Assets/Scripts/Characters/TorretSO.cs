using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Torret", menuName = "ScriptableObject/Torret")]
public class TorretSO : EnemySO
{
    public float ShootCoolDown = 2;
    public GameObject BulletPrefab;
    public Bullet Bullet;
}
