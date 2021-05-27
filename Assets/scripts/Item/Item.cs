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

    public Type type;       //Ží—Þ
    public Sprite sprite;  //Slot‚É•\Ž¦‚·‚é‰æ‘œ
    public GameObject zoomObj;

    public Item(Type type, Sprite sprite, GameObject zoomObj)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomObj = zoomObj;
    }
}
