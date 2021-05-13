using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jinneko : MonoBehaviour
{
    //クリックした時に、Playerがアイテム(ねこじゃらし)を持っていれば消える
    //・タイミング：クリックしたとき
    //・処理：消える
    //・処理の条件：Playerがアイテム(ねこじゃらし)を持っていれば

    //・タイミング：クリックしたとき
    /* public void OnThis()
     {
         bool hasItem = ItemBox.instance.CanUseItem(Item.Type.NekojarashiA);  //TODO:アイテムボックスにアイテム(ねこじゃらし)があるかどうか　→アイテムとアイテムBOXを作る
         if (hasItem == true)  //Playerがアイテム(ねこじゃらし)を持っていれば
         {
             //処理：消える
             gameObject.SetActive(false);
             //アイテムを使う
             ItemBox.instance.UseItem(Item.Type.NekojarashiA);
         }
     }*/
}
