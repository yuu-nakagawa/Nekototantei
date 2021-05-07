using System;
using UnityEngine;

[Serializable]
public class Item1
{
    public enum Type
    {
        nekojarashiA,
        nekojarashiB,
        nekojarashiA1,
    }

    public Type type;       //Ží—Þ
    public Sprite sprite;  //Slot‚É•\Ž¦‚·‚é‰æ‘œ

    public Item1(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
