using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupObj : MonoBehaviour
{
    [SerializeField] Item.Type itemType;
    Item item;
    //[SerializeField] Item1 item;
    //ƒNƒŠƒbƒN‚µ‚½‚çÁ‚·

    private void Start()
    {
        //itemType‚É‰‚¶‚Äitem‚ğ¶¬‚·‚é
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
