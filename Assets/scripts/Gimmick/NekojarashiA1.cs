using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekojarashiA1 : MonoBehaviour
{
    //アイテムの表示・非表示
    public GameObject Nekojarashi_A1;
    public GameObject Nekojarashi_A;
   
    //猫じゃらしA1をタップしたら、猫じゃらしA1を非表示、猫じゃらしAを表示する
    //・タイミング：クリックしたとき
    //・処理：猫じゃらしA1を非表示
    //・処理：猫じゃらしAを表示する

    //・タイミング：クリックしたとき
    public void OnNekojarashiA()
    {
        //処理：猫じゃらしA1を非表示
        Nekojarashi_A1.SetActive(false);
        //猫じゃらしAを表示する
        Nekojarashi_A.SetActive(true);

    }    
}
