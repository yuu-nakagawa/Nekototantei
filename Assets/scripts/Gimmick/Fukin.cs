using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fukin : MonoBehaviour
{
    //アイテムの表示・非表示
    public GameObject Fukin_A1;
    public GameObject Fukin_A;

    //布巾A1をタップしたら、布巾A1を非表示、布巾Aを表示する
    //・タイミング：クリックしたとき
    //・処理：布巾A1を非表示
    //・処理：布巾Aを表示する

    //・タイミング：クリックしたとき

    public void OnFukin()
    {
        //処理：布巾A1を非表示
        Fukin_A1.SetActive(false);
        //布巾Aを表示する
        Fukin_A.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
