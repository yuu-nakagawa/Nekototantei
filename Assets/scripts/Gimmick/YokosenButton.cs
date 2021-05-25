using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YokosenButton : MonoBehaviour
{
    //フラグを立てる
    bool flag = true;
    //表示している画像
    public Image button0;
    public Image button1;
    public Image button2;
    public Image button3;
    public Image button4;
    public Image button5;
    public Image button6;

    //画像のソース
    public Sprite markSource0;
    public Sprite markSource1;
    public Sprite markSource2;
    //public Sprite markSource3;

    //現在のマーク
    enum Mark
    {
        Shita,
        Naka,
        Ue,
       // Daia,
    }
    Mark currentMark0 = Mark.Shita;
    Mark currentMark1 = Mark.Shita;
    Mark currentMark2 = Mark.Shita;
    Mark currentMark3 = Mark.Shita;
    Mark currentMark4 = Mark.Shita;
    Mark currentMark5 = Mark.Shita;
    Mark currentMark6 = Mark.Shita;

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
    //・マーク変数を変更する
    /* void ChangeMark(int position)
    {
       if (position == 0)
        {
            currentMark0++;
        }
        else if (position == 1)
         {
            currentMark1++;
         }
        else if (position == 2)
        {
            currentMark2++;
        }
        else if (position == 3)
        {
            currentMark3++;
        }
        else if (position == 4)
        {
            currentMark0 = 0;
            position = 0;
        }
}*/
    public void Nibyou()
    {
        GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(-4600, 6500);
        GameObject.Find("higashiPanel/takarabako_button").SetActive(false);
        GameObject.Find("higashiPanel").transform.Find("takarabako_aki_button").gameObject.SetActive(true);
    }

    void ChangeMark(int position)
    {
        switch (position)
        {
            case 0:
                if (currentMark0 == Mark.Ue)
                {
                    currentMark0 = 0;
                }
                else
                {
                    currentMark0++;
                }
                break;
            case 1:
                if (currentMark1 == Mark.Ue)
                {
                    currentMark1 = 0;
                }
                else
                {
                    currentMark1++;
                }
                break;
            case 2:
                if (currentMark2 == Mark.Ue)
                {
                    currentMark2 = 0;
                }
                else
                {
                    currentMark2++;
                }
                break;
            case 3:
                if (currentMark3 == Mark.Ue)
                {
                    currentMark3 = 0;
                }
                else
                {
                    currentMark3++;
                }
                break;
            case 4:
                if (currentMark4 == Mark.Ue)
                {
                    currentMark4 = 0;
                }
                else
                {
                    currentMark4++;
                }
                break;
            case 5:
                if (currentMark5 == Mark.Ue)
                {
                    currentMark5 = 0;
                }
                else
                {
                    currentMark5++;
                }
                break;
            case 6:
                if (currentMark6 == Mark.Ue)
                {
                    currentMark6 = 0;
                }
                else
                {
                    currentMark6++;
                }
                break;
        }
        
        if ((currentMark0 == Mark.Shita)
            && (currentMark1 == Mark.Ue)
            && (currentMark2 == Mark.Naka)
            && (currentMark3 == Mark.Shita)
            && (currentMark4 == Mark.Shita)
            && (currentMark5 == Mark.Ue)
            && (currentMark6 == Mark.Naka))
        {
            flag = false;
            Invoke("Nibyou", 1.0f);
            //GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(-4600, 6500);
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
                button0.sprite = GetSource(currentMark0);
                break;
            case 1:
                //button1の画像を変えたい
                button1.sprite = GetSource(currentMark1);
                break;
            case 2:
                //button2の画像を変えたい
                button2.sprite = GetSource(currentMark2);
                break;
            case 3:
                //button3の画像を変えたい
                button3.sprite = GetSource(currentMark3);
                break;
            case 4:
                //button4の画像を変えたい
                button4.sprite = GetSource(currentMark4);
                break;
            case 5:
                //button5の画像を変えたい
                button5.sprite = GetSource(currentMark5);
                break;
            case 6:
                //button6の画像を変えたい
                button6.sprite = GetSource(currentMark6);
                break;
        }
    }
    //マーク変数に応じた画像ソースを取得する
    Sprite GetSource(Mark mark)
    {
        switch (mark)
        {
            case Mark.Shita:
                return markSource0;
            case Mark.Naka:
                return markSource1;
            case Mark.Ue:
                return markSource2;
            //case Mark.Daia:
               // return markSource3;
        }
        return null;
    }
    
}

