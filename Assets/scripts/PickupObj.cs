using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;
    //[SerializeField] Item1 item;
    //クリックしたら消す

    private void Start()
    {
        //itemTypeに応じてitemを生成する
        item = ItemGenerater.instance.Spawn(itemType);
    }
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        gameObject.SetActive(false);
        GameObject.Find("Yajirushi").transform.Find("ModoruYajirushi").gameObject.SetActive(true);
    }
    /*
    public void OnClickNekojarashiA()
    {
        //ItemBox.instance.SetItem(item);
        
        gameObject.SetActive(false);
    } */
}
