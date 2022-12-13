using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    Player player;
    TMP_Text TMP;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        TMP = GetComponent<TMP_Text>();
    }

    void Update()
    {
        TMP.text = player.GetCoins().ToString();
    }
}
