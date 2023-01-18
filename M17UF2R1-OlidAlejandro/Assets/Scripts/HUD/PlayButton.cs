using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void ResetGame() 
    {
        GameManager.Instance.ResetGame();
    }
}
