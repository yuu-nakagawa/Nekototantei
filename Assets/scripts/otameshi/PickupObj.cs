using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    //[SerializeField] Item1.Type item;
    [SerializeField] Item1 item;
    //�N���b�N���������
    public void OnClickObj()
    {
        ItemBox1.instance.SetItem(item);
        gameObject.SetActive(false);
    }
}
