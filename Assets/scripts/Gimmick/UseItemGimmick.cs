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

    public void OnClicktecho()
    {
        //アイテム鍵を持っているかどうか
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            gameObject.SetActive(false);
            //手帳を開いたパネルを表示する
            GameObject.Find("Panel10").transform.Find("techohiraku_Panel").gameObject.SetActive(true);
            //手帳ボタンを非表示にする
            GameObject.Find("techobutton").gameObject.SetActive(false);
            //手帳開くパネルを表示にする
            GameObject.Find("kitaPanel").transform.Find("techo_akibutton").gameObject.SetActive(true);
        }
    }
    
    public void Ithibyou()
    {
        GameObject.Find("rekodo_totteariPanel").gameObject.SetActive(false);
        GameObject.Find("Panel11").transform.Find("rekodo_hintoPanel").gameObject.SetActive(true);
    }
    public void OnClickrekodo()
    {
        //Debug.Log("クリックしたよ");
        //アイテム取っ手を持っているかどうか
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            gameObject.SetActive(false);
            //取っ手を付けたパネルを表示する
            GameObject.Find("Panel11").transform.Find("rekodo_totteariPanel").gameObject.SetActive(true);
            Invoke("Ithibyou", 1.5f);
        }
    }
}
