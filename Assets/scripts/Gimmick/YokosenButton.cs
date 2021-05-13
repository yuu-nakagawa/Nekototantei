using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YokosenButton : MonoBehaviour
{
    //表示している画像
    public Image button0;
    public Image button1;
    public Image button2;
    public Image button3;

    //画像のソース
    public Sprite markSource0;
    public Sprite markSource1;
    public Sprite markSource2;
    public Sprite markSource3;

    //現在のマーク
    enum Mark
    {
        Maru,
        Sankaku,
        Hosi,
        Daia,
    }
    Mark currentMark0 = Mark.Maru;
    Mark currentMark1 = Mark.Maru;
    Mark currentMark2 = Mark.Maru;
    Mark currentMark3 = Mark.Maru;

    //ボタンをクリックしたときの処理
    //・マーク変数を変更する
    //・マーク変数に応じた画像を表示する

    //ボタンをクリックしたときの処理
    public void OnClickButton(int position)
    {
        ChangeMark(position);
        ShowMarkImage(position);
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


    void ChangeMark(int position)
    {
        switch (position)
        {
            case 0:
                if (currentMark0 == Mark.Daia)
                {
                    currentMark0 = 0;
                }
                else
                {
                    currentMark0++;
                }
                break;
            case 1:
                if (currentMark1 == Mark.Daia)
                {
                    currentMark1 = 0;
                }
                else
                {
                    currentMark1++;
                }
                break;
            case 2:
                if (currentMark2 == Mark.Daia)
                {
                    currentMark2 = 0;
                }
                else
                {
                    currentMark2++;
                }
                break;
            case 3:
                if (currentMark3 == Mark.Daia)
                {
                    currentMark3 = 0;
                }
                else
                {
                    currentMark3++;
                }
                break;
        }
        
        if ((currentMark0 == Mark.Daia)
            && (currentMark1 == Mark.Hosi)
            && (currentMark2 == Mark.Maru)
            && (currentMark3 == Mark.Sankaku))
        {
            GameObject.Find("Canvas/PanelParent").transform.localPosition = new Vector2(-4600, 6500);
            GameObject.Find("higashiPanel/takarabako_button").SetActive(false);
            GameObject.Find("higashiPanel").transform.Find("takarabako_aki_button").gameObject.SetActive(true);
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
        }
    }
    //マーク変数に応じた画像ソースを取得する
    Sprite GetSource(Mark mark)
    {
        switch (mark)
        {
            case Mark.Maru:
                return markSource0;
            case Mark.Sankaku:
                return markSource1;
            case Mark.Hosi:
                return markSource2;
            case Mark.Daia:
                return markSource3;
        }
        return null;
    }
    /*
    public void CheckClear()
    {
        if (IsClear())
        {
            Debug.Log("クリア");
            ClearEvent.Invoke();
        }

        bool IsClear()
        {
            //正解しているかどうか
            //=>1つでも一致しなければfalse
            //=>全てのチェックをクリアすればtrue
            for (int i = 0; i < correctNumbers.Length; i++)
            {
                if (passwordButtons[i].number != correctNumbers[i])
                {
                    return false;
                }
            }
        }
    }*/
}

