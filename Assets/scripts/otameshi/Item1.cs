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

    public Type type;       //���
    public Sprite sprite;  //Slot�ɕ\������摜

    public Item1(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}
