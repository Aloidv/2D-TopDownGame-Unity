using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultMessage : MonoBehaviour
{
    public PlayerSO PlayerSO;
    TMP_Text TMP;

    void Start()
    {
        TMP = GetComponent<TMP_Text>();
        if (GameManager.Instance.Win)
        {
            TMP.text = "YOU WON CHEERS";
        }
        else
        {
            TMP.text = "YOU LOSE ...";
        }

        TMP.text += "\n COINS: " + PlayerSO.Coins.ToString();
    }
}
