using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Bullet", menuName = "ScriptableObject/Bullet")]
public class Bullet : ScriptableObject
{
    [SerializeField]
    Sprite Sprite;

    [SerializeField]
    int Velocity;

    [SerializeField]
    int Size;

    [SerializeField]
    string Name;

    [SerializeField]
    int Damage;

    public Sprite GetSprite()
    {
        return Sprite; 
    }

    public int GetDamage()
    {
        return Damage;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetVelocity()
    {
        return Velocity;
    }

    public int GetSize()
    {
        return Size;
    }
}
