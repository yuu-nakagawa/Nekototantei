using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemGimmick : MonoBehaviour
{
    //やりたいこと
    //アイテムねこじゃらしを持っている状態で、クリックすると消える
    //・クリック判定
    //・アイテム持ってますよ判定
    [SerializeField] Item.Type clearItem;

    public void OnClickObj()
    {
        //Debug.Log("クリックしたよ");
        //アイテム猫じゃらしを持っているかどうか
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if(clear == true)
        {
            //Debug.Log("ギミック解除");
            gameObject.SetActive(false);
        }
    }
}
