using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyCounter : MonoBehaviour
{
    public PlayerSO PlayerSO;
    TMP_Text TMP;

    void Start()
    {
        TMP = GetComponent<TMP_Text>();
    }

    void Update()
    {
        TMP.text = PlayerSO.EnemiesDefeated.ToString();
    }
}
