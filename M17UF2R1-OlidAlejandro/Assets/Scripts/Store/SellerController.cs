using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SellerController : MonoBehaviour
{
    [SerializeField]
    Canvas Store;
    
    [SerializeField]
    PlayerSO PlayerSO;
    
    [SerializeField]
    bool isStoreOpen = false;
    
    [SerializeField]
    InputMaster InputMaster;

    [SerializeField]
    ItemStore ItemStore_1;

    [SerializeField]
    ItemStore ItemStore_2;
    
    [SerializeField]
    ItemStore ItemStore_3;

    [SerializeField]
    PlayerController PlayerController;

    [SerializeField]
    LootListSO StoreAvaiableItemsSO;

    private void Start()
    {
        InputMaster = new InputMaster();
        InputMaster.Gameplay.Enable();
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        PlayerController = player.GetComponent<PlayerController>();
        //PlayerSO = player.GetComponent<PlayerSO>();
    }

    private void Update()
    {
        if (isStoreOpen)
        {
            InputBuyItem();
            InputStoreExit();
        }
    }

    private void RefillStore()
    {
        ItemStore_1.Item = StoreAvaiableItemsSO.GetRandomItem();
        ItemStore_2.Item = StoreAvaiableItemsSO.GetRandomItem();
        ItemStore_3.Item = StoreAvaiableItemsSO.GetRandomItem();

        ItemStore_1.ImageItemStore.GetComponentInChildren<Image>().sprite = ItemStore_1.Item.GetSprite();
        ItemStore_2.ImageItemStore.GetComponentInChildren<Image>().sprite = ItemStore_2.Item.GetSprite();
        ItemStore_3.ImageItemStore.GetComponentInChildren<Image>().sprite = ItemStore_3.Item.GetSprite();

        ItemStore_1.TextItemStore.GetComponentInChildren<TMP_Text>().text = ItemStore_1.TextItemStore.text;
        ItemStore_2.TextItemStore.GetComponentInChildren<TMP_Text>().text = ItemStore_2.TextItemStore.text;
        ItemStore_3.TextItemStore.GetComponentInChildren<TMP_Text>().text = ItemStore_3.TextItemStore.text;
    }

    private void InputBuyItem()
    {

    }

   /* public void BuyItem()
  /*  {
        PlayerSO.Coins -= Item.GetPrice();

        switch (Item.GetName())
        {
            case "Health":
                PlayerController.Healing();
                break;
            default:
                PlayerController.TakeWeapon(AvaiableWeapons.findByName(Item.GetName()));
                break;
        }
    }*/

    private void InputStoreExit()
    {
        if (InputMaster.Gameplay.Dash.WasPressedThisFrame() && isStoreOpen)
        {
            CloseStore();
        }
    }

    private void CloseStore()
    {
        isStoreOpen = false;
        Store.gameObject.SetActive(false);
        GameManager.Instance.ResumeGame();
    }

    private void OpenStore()
    {
        RefillStore();
        isStoreOpen = true;
        Store.gameObject.SetActive(true);
        GameManager.Instance.PauseGame();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (collision.GetComponent<PlayerController>().playerSO.isPurchasing)
            {
                OpenStore();
            }
        }
    }
}
