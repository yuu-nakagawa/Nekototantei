using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AshiatoButtun : MonoBehaviour
{
    //正解
    public int[] answer = { 1, 0, 2, 0, 3, 0 };
    //public Image[] answer = {};

    //入力配列
    public static int[] nyuuryoku = new int[0];
    
    //入力
    public void OnClick(int position)
    {
        Array.Resize(ref nyuuryoku, nyuuryoku.Length + 1);
        nyuuryoku[nyuuryoku.Length - 1] = position;
        Debug.Log(position);

        if (nyuuryoku.Length == 6)
        {
            if (Answer() == true)
            {
                GameObject.Find("kohimekaButtunPanel").SetActive(false);
            }
            else
            {
                Array.Resize(ref nyuuryoku, 0 );
            }
            Debug.Log("Answer");
        }
    }

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

