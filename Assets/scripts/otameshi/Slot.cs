using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //�A�C�e�����󂯎������摜���X���b�g�ɕ\�����Ă��
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
