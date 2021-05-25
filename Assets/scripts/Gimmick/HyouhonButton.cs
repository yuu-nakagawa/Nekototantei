using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HyouhonButton : MonoBehaviour
{
    //フラグを立てる
    bool flag = true;
    //表示している画像
    public Image[] button = new Image[8];
    
    //画像のソース
    public Sprite[] markSource = new Sprite[3];
    
    //現在のマーク
    enum Mark
    {
        Tentoumushi,
        Chou,
        Kuwagata
    }
    private Mark[] currentMark = new Mark[8];
    private void Start()
    {
        for (int i = 0; i < currentMark.Length; i++)
        {
            currentMark[i] = Mark.Tentoumushi;
        }
    }

    //ボタンをクリックしたときの処理
    //・マーク変数を変更する
    //・マーク変数に応じた画像を表示する


    //ボタンをクリックしたときの処理
    public void OnClickButton(int position)
    {
        if (flag == true)
        {
            ChangeMark(position);
            ShowMarkImage(position);
        }        
    }

    public void Nibyou()
    {
        GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(0, 7800);
        GameObject.Find("higashiPanel/hyouhon_nyuryokubutton").SetActive(false);
        GameObject.Find("higashiPanel").transform.Find("hyouhon_aki_kubutton").gameObject.SetActive(true);
    }
    
    //・マーク変数を変更する    
     void ChangeMark(int position)
    {
        switch (position)
        {
            case 0:
                if (currentMark[0] == Mark.Kuwagata)
                {
                    currentMark[0] = 0;
                }
                else
                {
                    currentMark[0]++;
                }
                break;
            case 1:
                if (currentMark[1] == Mark.Kuwagata)
                {
                    currentMark[1] = 0;
                }
                else
                {
                    currentMark[1]++;
                }
                break;
            case 2:
                if (currentMark[2] == Mark.Kuwagata)
                {
                    currentMark[2] = 0;
                }
                else
                {
                    currentMark[2]++;
                }
                break;
            case 3:
                if (currentMark[3] == Mark.Kuwagata)
                {
                    currentMark[3] = 0;
                }
                else
                {
                    currentMark[3]++;
                }
                break;
            case 4:
                if (currentMark[4] == Mark.Kuwagata)
                {
                    currentMark[4] = 0;
                }
                else
                {
                    currentMark[4]++;
                }
                break;
            case 5:
                if (currentMark[5] == Mark.Kuwagata)
                {
                    currentMark[5] = 0;
                }
                else
                {
                    currentMark[5]++;
                }
                break;
            case 6:
                if (currentMark[6] == Mark.Kuwagata)
                {
                    currentMark[6] = 0;
                }
                else
                {
                    currentMark[6]++;
                }
                break;
            case 7:
                if (currentMark[7] == Mark.Kuwagata)
                {
                    currentMark[7] = 0;
                }
                else
                {
                    currentMark[7]++;
                }
                break;
        }

        if ((currentMark[0] == Mark.Chou)
            && (currentMark[1] == Mark.Kuwagata)
            && (currentMark[2] == Mark.Tentoumushi)
            && (currentMark[3] == Mark.Tentoumushi)
            && (currentMark[4] == Mark.Tentoumushi)
            && (currentMark[5] == Mark.Chou)
            && (currentMark[6] == Mark.Chou)
            && (currentMark[7] == Mark.Kuwagata))
        {
            flag = false;
            Invoke("Nibyou", 1.0f);
            
        }
    }
    //・マーク変数に応じた画像を表示する
    void ShowMarkImage(int position)
    {
        switch (position)
        {
            case 0:
                //button0の画像を変えたい
                button[0].sprite = GetSource(currentMark[0]);
                break;
            case 1:
                //button1の画像を変えたい
                button[1].sprite = GetSource(currentMark[1]);
                break;
            case 2:
                //button2の画像を変えたい
                button[2].sprite = GetSource(currentMark[2]);
                break;
            case 3:
                //button3の画像を変えたい
                button[3].sprite = GetSource(currentMark[3]);
                break;
            case 4:
                //button4の画像を変えたい
                button[4].sprite = GetSource(currentMark[4]);
                break;
            case 5:
                //button5の画像を変えたい
                button[5].sprite = GetSource(currentMark[5]);
                break;
            case 6:
                //button6の画像を変えたい
                button[6].sprite = GetSource(currentMark[6]);
                break;
            case 7:
                //button7の画像を変えたい
                button[7].sprite = GetSource(currentMark[7]);
                break;

        }
    }

    //マーク変数に応じた画像ソースを取得する
    Sprite GetSource(Mark mark)
    {
        switch (mark)
        {
            case Mark.Tentoumushi:
                return markSource[0];
            case Mark.Chou:
                return markSource[1];
            case Mark.Kuwagata:
                return markSource[2];            
        }
        return null;
    }
    
}

