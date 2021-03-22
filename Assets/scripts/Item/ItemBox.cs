using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    /*
    public GameObject Itemimage0;
    public GameObject Itemimage1;
    public GameObject Itemimage2;
    public GameObject Itemimage3;
    public GameObject Itemimage4;
    public GameObject Itemimage5;
    */

    //配列を使うと管理が楽になる
    public GameObject[] boxs;

    //処理
    //TODO:アイテムボックスにアイテム(ねこじゃらし)を格納する：画像を表示させる
    //特定のアイテムを持っているかどうかを調べる
    //アイテムを使用する：画像を非表示にする

    //static化して、どのファイルからでも参照できるようにする
    public static ItemBox instance;
    private void Awake()
    {
        instance = this;
    }
    
    public void SetItem(Item.Type type)
    {
        int index = (int)type; //NekojarashiAは0、NekojarashiBは1
        boxs[index].SetActive(true);
        /*
        if (type == Item.Type.NekojarashiA)
        {
            Itemimage0.SetActive(true);
            boxs[0].SetActive(true);
        }
        else if (type == Item.Type.NekojarashiB)
        {
            Itemimage1.SetActive(true);
            boxs[1].SetActive(true);
        }
        */
        
    }
    public bool CanUseItem(Item.Type type)
    {
        //アイテムを使えるかどうかは、表示されているかどうかがわかればいい
        //表示されているかどうかは、activeselfを使えばいい
        int index = (int)type; //NekojarashiAは0、NekojarashiBは1
        return boxs[index].activeSelf;
        /*
        if (type == Item.Type.NekojarashiA)
        {
            return Itemimage0.activeSelf;
        }
        if (type == Item.Type.NekojarashiB)
        {
            return Itemimage1.activeSelf;
        }
        return false;
        */
    }
    public void UseItem(Item.Type type)
    {
        int index = (int)type; //NekojarashiAは0、NekojarashiBは1
        boxs[index].SetActive(false);
        /*
        if (type == Item.Type.NekojarashiA)
        {
            Itemimage0.SetActive(false);
        }
        else if (type == Item.Type.NekojarashiB)
        {
            Itemimage1.SetActive(false);
        }*/
    }
}
