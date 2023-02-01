using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Loot List", menuName = "ScriptableObject/Loot List")]
public class LootListSO : ScriptableObject
{
    public List<Loot> List;

    public Loot GetRandomItem()
    {
        int randomNum = Random.Range(1, 101);
        List<Loot> itemList = new List<Loot>();
        foreach (Loot item in List)
        {
            if (randomNum <= item.GetChance())
            {
                itemList.Add(item);
            }
        }

        return itemList[Random.Range(0, itemList.Count)];
    }
}
