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

    public int GetChance()
    {
        return Chance;
    }

    public string GetName()
    {
        return Name;
    }

    public Sprite GetSprite()
    {
        return Sprite;
    }
}
