using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Loot", menuName = "ScriptableObject/Loot")]
public class Loot : ScriptableObject
{

    [SerializeField]
    internal Sprite Sprite;

    [SerializeField]
    internal string Name;

    [SerializeField]
    internal int Chance;

    [SerializeField]
    internal int Price;

    public int GetChance()
    {
        return Chance;
    }

    public int GetPrice()
    {
        return Price;
    }

    public string GetName()
    {
        return Name;
    }

    public Sprite GetSprite()
    {
        return Sprite;
    }

    public virtual void ApplyBust(PlayerController p)
    {

    }
}
