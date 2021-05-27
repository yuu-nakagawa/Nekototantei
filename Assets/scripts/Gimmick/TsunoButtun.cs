using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsunoButtun : MonoBehaviour
{
    //正解
    public int[] answer = { 1, 1, 1, 0, 0, 1, 1, 0 };

    //入力配列
    public static int[] nyuuryoku = new int[0];
    
    public void Ithibyou()
    {
        GameObject.Find("shikaPanel").SetActive(false);
        GameObject.Find("Panel9").transform.Find("shika_akiPanel").gameObject.SetActive(true);
    }
    //入力
    public void OnClick(int position)
    {
        //配列を1増やす
        Array.Resize(ref nyuuryoku, nyuuryoku.Length + 1);
        nyuuryoku[nyuuryoku.Length - 1] = position;

        if (nyuuryoku.Length == 8)
        {
            //正解したらshikaPanelを非表示
            //shika_akiPanelを表示する
            if (Answer() == true)
            {
                Invoke("Ithibyou", 1.0f);
            }
            else
            {
                //配列を空にする
                Array.Resize(ref nyuuryoku, 0 );
            }
        }
    }
    //正解と入力が一致するか確認する
    bool Answer()
    {
        for (int i = 0; i < answer.Length; i++)
        {
            if (answer[i] != nyuuryoku[i])
            {
                return false;
            }
        }
        return true;
    }
}

