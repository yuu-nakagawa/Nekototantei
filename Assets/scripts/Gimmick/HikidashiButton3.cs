using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HikidashiButton3 : MonoBehaviour
{
    //フラグを立てる
    bool flag = true;
    //表示している画像
    public Image[] button = new Image[4];
   
    //画像のソース
    public Sprite[] markSource = new Sprite[4];
    
    //現在のマーク
    enum Mark
    {
        Yoroppa,
        Minamiamerika,
        Kitaamerika,
        Ahurika,        
    }
    private Mark[] currentMark = new Mark[4];
    private void Start()
    {
        for (int i = 0; i < currentMark.Length; i++)
        {
            currentMark[i] = Mark.Minamiamerika;
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
        GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(-2300, 6500);
        GameObject.Find("higashiPanel/hikidashi3button").SetActive(false);
        GameObject.Find("higashiPanel").transform.Find("hikidashi3_aki_button").gameObject.SetActive(true);
    }
    
    //・マーク変数を変更する    
     void ChangeMark(int position)
    {
        switch (position)
        {
            case 0:
                if (currentMark[0] == Mark.Ahurika)
                {
                    currentMark[0] = 0;
                }
                else
                {
                    currentMark[0]++;
                }
                break;
            case 1:
                if (currentMark[1] == Mark.Ahurika)
                {
                    currentMark[1] = 0;
                }
                else
                {
                    currentMark[1]++;
                }
                break;
            case 2:
                if (currentMark[2] == Mark.Ahurika)
                {
                    currentMark[2] = 0;
                }
                else
                {
                    currentMark[2]++;
                }
                break;
            case 3:
                if (currentMark[3] == Mark.Ahurika)
                {
                    currentMark[3] = 0;
                }
                else
                {
                    currentMark[3]++;
                }
                break;            
        }

        if ((currentMark[0] == Mark.Yoroppa)
            && (currentMark[1] == Mark.Kitaamerika)
            && (currentMark[2] == Mark.Ahurika)
            && (currentMark[3] == Mark.Minamiamerika))
        {
            flag = false;
            Invoke("Nibyou", 1.0f);
            //GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(0, 2600);
            //GameObject.Find("higashiPanel/takarabako_button").SetActive(false);
            //GameObject.Find("higashiPanel").transform.Find("takarabako_aki_button").gameObject.SetActive(true);
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
        }
    }

    //マーク変数に応じた画像ソースを取得する
    Sprite GetSource(Mark mark)
    {
        switch (mark)
        {
            case Mark.Yoroppa:
                return markSource[0];
            case Mark.Minamiamerika:
                return markSource[1];
            case Mark.Kitaamerika:
                return markSource[2];
            case Mark.Ahurika:
                return markSource[3];            
        }
        return null;
    }
    
}

