using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //アイテムを受け取ったら画像をスロットに表示してやる
    Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public void SetItem(Item1 item)
    {
        UpdataImage(item);
    }

    void UpdataImage(Item1 item)
    {
        image.sprite = item.sprite;
    }
}
