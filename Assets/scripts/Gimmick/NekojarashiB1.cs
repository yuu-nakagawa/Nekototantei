using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekojarashiB1 : MonoBehaviour
{
    //アイテムの表示・非表示
    public GameObject Nekojarashi_B1;
    public GameObject Nekojarashi_B;

    //猫じゃらしB1をタップしたら、猫じゃらしB1を非表示、猫じゃらしBを表示する
    //猫じゃらしB1をタップしたら、猫じゃらしB1を非表示、猫じゃらしBを表示する
    //・タイミング：クリックしたとき
    //・処理：猫じゃらしB1を非表示
    //・処理：猫じゃらしBを表示する

    //・タイミング：クリックしたとき
    public void OnNekojarashiB()
    {
        //処理：猫じゃらしB1を非表示
        Nekojarashi_B1.SetActive(false);
        //猫じゃらしBを表示する
        Nekojarashi_B.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
