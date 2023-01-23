using UnityEngine;

public class SellerController : MonoBehaviour
{
    public Canvas Store;
    public PlayerSO playerSO;
    private bool isStoreOpen = false;
    InputMaster InputMaster;

    private void Start()
    {
        InputMaster = new InputMaster();
        InputMaster.Gameplay.Enable();
    }

    private void Update()
    {
        if (isStoreOpen)
        {
            InputBuyItem();
            InputStoreExit();

        }
    }

    private void InputBuyItem()
    {

    }

    private void InputStoreExit()
    {
        if (InputMaster.Gameplay.Dash.WasPressedThisFrame())
        {
            isStoreOpen = false;
            Store.gameObject.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerController>().playerSO.isPurchasing)
            {
                Store.gameObject.SetActive(true);
                isStoreOpen = true;
            }
        }
    }
}
