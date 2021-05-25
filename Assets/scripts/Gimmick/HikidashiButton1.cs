using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HikidashiButton1 : MonoBehaviour
{
    //フラグを立てる
    bool flag = true;
    //表示している画像
    public Image[] button = new Image[8];
    //public Image button1;
    //public Image button2;
    //public Image button3;
    //public Image button4;
    //public Image button5;
    //public Image button6;
    //public Image button7;

    //画像のソース
    public Sprite[] markSource = new Sprite[6];
    //public Sprite markSource1;
    //public Sprite markSource2;
    //public Sprite markSource3;

    //現在のマーク
    enum Mark
    {
        K,
        O,
        N,
        E,
        T,
        I
    }
    private Mark[] currentMark = new Mark[8];
    private void Start()
    {
        for (int i = 0; i < currentMark.Length; i++)
        {
            currentMark[i] = Mark.K;
        }
    }

    //Mark currentMark0 = Mark.K;
    //Mark currentMark1 = Mark.K;
    //Mark currentMark2 = Mark.K;
    //Mark currentMark3 = Mark.K;
    //Mark currentMark4 = Mark.K;
    //Mark currentMark5 = Mark.K;
    //Mark currentMark6 = Mark.K;

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
        GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(0, 2600);
        GameObject.Find("higashiPanel/hikidashi1button").SetActive(false);
        GameObject.Find("higashiPanel").transform.Find("hikidashi1_aki_button").gameObject.SetActive(true);
    }
    
    //・マーク変数を変更する    
     void ChangeMark(int position)
    {
        switch (position)
        {
            case 0:
                if (currentMark[0] == Mark.I)
                {
                    currentMark[0] = 0;
                }
                else
                {
                    currentMark[0]++;
                }
                break;
            case 1:
                if (currentMark[1] == Mark.I)
                {
                    currentMark[1] = 0;
                }
                else
                {
                    currentMark[1]++;
                }
                break;
            case 2:
                if (currentMark[2] == Mark.I)
                {
                    currentMark[2] = 0;
                }
                else
                {
                    currentMark[2]++;
                }
                break;
            case 3:
                if (currentMark[3] == Mark.I)
                {
                    currentMark[3] = 0;
                }
                else
                {
                    currentMark[3]++;
                }
                break;
            case 4:
                if (currentMark[4] == Mark.I)
                {
                    currentMark[4] = 0;
                }
                else
                {
                    currentMark[4]++;
                }
                break;
            case 5:
                if (currentMark[5] == Mark.I)
                {
                    currentMark[5] = 0;
                }
                else
                {
                    currentMark[5]++;
                }
                break;
            case 6:
                if (currentMark[6] == Mark.I)
                {
                    currentMark[6] = 0;
                }
                else
                {
                    currentMark[6]++;
                }
                break;
            case 7:
                if (currentMark[7] == Mark.I)
                {
                    currentMark[7] = 0;
                }
                else
                {
                    currentMark[7]++;
                }
                break;
        }

        if ((currentMark[0] == Mark.N)
            && (currentMark[1] == Mark.E)
            && (currentMark[2] == Mark.K)
            && (currentMark[3] == Mark.O)
            && (currentMark[4] == Mark.N)
            && (currentMark[5] == Mark.T)
            && (currentMark[6] == Mark.E)
            && (currentMark[7] == Mark.I))
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
            case Mark.K:
                return markSource[0];
            case Mark.O:
                return markSource[1];
            case Mark.N:
                return markSource[2];
            case Mark.E:
                return markSource[3];
            case Mark.T:
                return markSource[4];
            case Mark.I:
                return markSource[5];
        }
        return null;
    }
    
}

