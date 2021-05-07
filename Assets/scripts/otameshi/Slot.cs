using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    Item1 item;
    Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }
    public void SetItem(Item1 item)
    {
        this.item = item;
        UpdataImage(item);
    }

    //アイテムを受け取ったら画像をスロットに表示してやる
    void UpdataImage(Item1 item)
    {
        image.sprite = item.sprite;
    }
}
