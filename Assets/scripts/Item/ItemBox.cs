using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    //��肽������
    //slot���󂢂Ă���A�ォ�����Ă���
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;
    //�ǂ��ł����s�ł�����
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            slots = GetComponentsInChildren<Slot>();
        }
    }
    // PickupObj���N���b�N���ꂽ��A�X���b�g�ɃA�C�e��������
    public void SetItem(Item item)
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

    public void OnSelectSlot(int position)
    {
        //��U�S�ẴX���b�g�̑I���p�l�����\��
        foreach (Slot slot in slots)
        {
            slot.HideBGPanel();
        }
        selectedSlot = null;

        //�I�����ꂽ�X���b�g�̑I���p�l����\��
        if (slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
    }

    //�A�C�e���̎g�p�����݂�&�g����Ȃ�g���Ă��܂�
    public bool TryUseItem(Item.Type type)
    {
        //�I���X���b�g�����邩�ǂ���
        if (selectedSlot == null)
        {
            return false;
        }
        if (selectedSlot.GetItem().type == type)
        {
            selectedSlot.SetItem(null);
            selectedSlot.HideBGPanel();
            selectedSlot = null;
            return true;
        }
        return false;
    }

    public Item GetSelectedItem()
    {
        if (selectedSlot == null)
        {
            return null;
        }
        return selectedSlot.GetItem();
    }
}
