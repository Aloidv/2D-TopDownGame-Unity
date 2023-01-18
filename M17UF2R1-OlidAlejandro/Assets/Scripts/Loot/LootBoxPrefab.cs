using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBoxPrefab : MonoBehaviour
{
    [SerializeField]
    GameObject ItemPrefab;

    [SerializeField]
    LootList LootList;

    [SerializeField]
    float dropForce = 3f;

    Loot GetItem()
    {
        int randomNum = Random.Range(1, 101);
        List<Loot> itemList = new List<Loot>();
        foreach (Loot item in LootList.List)
        {
            if (randomNum <= item.GetChance())
            {
                itemList.Add(item);
            }
        }
        
        return itemList[Random.Range(0, itemList.Count)];
    }

    public void DropLot()
    {
        Loot droppedItem = GetItem();
        if (droppedItem != null)
        {
            GameObject item = Instantiate(ItemPrefab, transform.position, Quaternion.identity);
            item.GetComponent<SpriteRenderer>().sprite = droppedItem.GetSprite();
            item.GetComponent<LootPrefab>().Loot = droppedItem;

            Vector2 dropDirection = new Vector2(Random.Range(-1, 1f), Random.Range(-1, 1));
            item.GetComponent<Rigidbody2D>().AddForce(dropDirection * dropForce, ForceMode2D.Impulse);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("Enemy") && !gameObject.CompareTag("Enemy"))
        {
            DropLot();
            Destroy(gameObject);
        }
    }
}
