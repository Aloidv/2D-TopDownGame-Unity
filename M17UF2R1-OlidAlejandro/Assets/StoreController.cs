using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreController : MonoBehaviour
{
    private void Start()
    {
        var playerSO = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().playerSO;
        
    }

    private void Update()
    {
    }
}
