using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox1 : MonoBehaviour
{
    //��肽������
    //slot���󂢂Ă���A�ォ�����Ă���
    [SerializeField] Slot[] slots;
    //�ǂ��ł����s�ł�����
    public static ItemBox1 instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // PickupObj���N���b�N���ꂽ��A�X���b�g�ɃA�C�e��������
    public void SetItem(Item1 item)
    {
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
        /*
        if (slots[0].IsEmpty())
        {
            slots[0].SetItem(item);
        }
        else if (slots[1].IsEmpty())
        {
            slots[1].SetItem(item);
        }
        else if (slots[2].IsEmpty())
        {
            slots[2].SetItem(item);
        }
        //Debug.Log(type); */
    }
}
