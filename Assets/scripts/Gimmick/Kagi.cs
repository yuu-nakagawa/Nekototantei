using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kagi : MonoBehaviour
{
    //アイテムの表示・非表示
    public GameObject KagiA1;
    public GameObject KagiA;

    //鍵A1をタップしたら、鍵A1を非表示、鍵Aを表示する
    //・タイミング：クリックしたとき
    //・処理：鍵A1を非表示
    //・処理：鍵Aを表示する

    //・タイミング：クリックしたとき
  
    public void OnKagiA()
    {
        //処理：鍵A1を非表示
        KagiA1.SetActive(false);
        //鍵Aを表示する
        KagiA.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
