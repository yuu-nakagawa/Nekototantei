using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    //クリックしたときに、アイテムBOXに格納
    //タイミング：クリックしたとき
    //処理：アイテムBOXに格納され、非表示になる。

    //種類がある：列挙型で管理
    public enum Type
    {
        NekojarashiA,
        NekojarashiB,
        KagiA,

    }

    public Type type;

    //タイミング：クリックしたとき
    public void OnThis()
    {
        ItemBox.instance.SetItem(type);  //TODO：アイテムBOXに格納する
        gameObject.SetActive(false);  //非表示にする
        //Debug.Log(type + "を取得");
    }
}
