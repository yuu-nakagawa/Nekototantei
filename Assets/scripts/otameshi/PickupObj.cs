using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item1.Type itemType;
    Item1 item;
    //[SerializeField] Item1 item;
    //�N���b�N���������

    private void Start()
    {
        //itemType�ɉ�����item�𐶐�����
        item = ItemGenerater.instance.Spawn(itemType);
    }
    public void OnClickObj()
    {
        ItemBox1.instance.SetItem(item);
        gameObject.SetActive(false);
    }

    public void OnClickNekojarashiA()
    {
        //ItemBox1.instance.SetItem(item);
        
        gameObject.SetActive(false);
    }
}
