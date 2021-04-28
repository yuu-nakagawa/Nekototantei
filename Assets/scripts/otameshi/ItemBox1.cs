using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox1 : MonoBehaviour
{
    //
    [SerializeField] Slot[] slots;
    //どこでも実行できるやつ
    public static ItemBox1 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // PickupObjがクリックされたら、スロットにアイテムを入れる
    public void SetItem(Item1 item)
    {
        slots[0].SetItem(item);
        //Debug.Log(type);
    }
}
