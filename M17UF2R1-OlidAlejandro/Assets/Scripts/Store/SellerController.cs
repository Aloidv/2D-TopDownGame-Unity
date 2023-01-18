using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellerController : MonoBehaviour
{
    public CanvasRenderer Store;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var option = collision.GetComponent<PlayerController>().playerSO.isPurchasing;
            if (option)
            {
                Store.gameObject.SetActive(true);
            }
        }
    }
}
