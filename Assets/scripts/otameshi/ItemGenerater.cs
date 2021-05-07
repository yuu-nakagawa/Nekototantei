using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    [SerializeField] ItemListEntity itemListEntity;

    public static ItemGenerater instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public Item1 Spawn(Item1.Type type)
    {
        //itemList‚Ì’†‚©‚çtype‚Æˆê’v‚µ‚½‚ç“¯‚¶item‚ğ¶¬‚µ‚Ä“n‚·
        foreach (Item1 item in itemListEntity.itemList)
        {
            if (item.type == type)
            {
                return new Item1(item.type,item.sprite);
            }
        }
        return null;
    }
}
