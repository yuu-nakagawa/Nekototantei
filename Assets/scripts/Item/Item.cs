using System;
using UnityEngine;

[Serializable]
public class Item
{
    public enum Type
    {
        NekojarashiA,
        NekojarashiB,
        KagiA,
        fukinA,
        NekojarashiA1,
        rekodo_totteA,
    }

    public Type type;       //種類
    public Sprite sprite;  //Slotに表示する画像
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite, GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
