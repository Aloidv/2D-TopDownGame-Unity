using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public PlayerSO PlayerSO;
    TMP_Text TMP;

    void Start()
    {
        TMP = GetComponent<TMP_Text>();
    }

    void Update()
    {
        TMP.text = PlayerSO.Coins.ToString();
    }
}
