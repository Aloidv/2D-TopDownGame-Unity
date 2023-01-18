using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProvisionalExit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.CheckVictory();

            if (GameManager.Instance.Win)
            {
                GameManager.Instance.LoadResultScene();
            }
        }
    }

}
