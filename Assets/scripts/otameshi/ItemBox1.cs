using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox1 : MonoBehaviour
{
    //
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
        slots[0].SetItem(item);
        //Debug.Log(type);
    }
}
