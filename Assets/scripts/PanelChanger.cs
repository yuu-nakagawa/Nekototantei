using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//矢印をクリックしたら、特定のPanelを表示する
public class PanelChanger : MonoBehaviour
{
    //矢印の表示・非表示
    public GameObject modoruYajirushi;

    //列挙型：ミスを減らす
    //使うものを列挙する
    enum Panel
    {
        Panel0,
        Panel1,
        Panel2,
        Panel3,
        Panel4,
        Panel5,
        Panel6,
        Panel7,
        Panel8,
        Panel9,
        Panel10,
        Panel11,
        Panel12,
        Panel13,
        Panel14,
        Panel15,
        Panel16

    }
    Panel currentPanel = Panel.Panel0;

    private void Start()
    {
        modoruYajirushi.SetActive(false);
    }

    void ShowPanel(Panel nextPanel)
    {
        currentPanel = nextPanel;

        if (nextPanel == Panel.Panel0)
        {
            //Panel0(西)を表示したい：Parentの位置を(0,0,0)
            this.transform.localPosition = new Vector2(0, 0);
            modoruYajirushi.SetActive(false);
        }
        else if (nextPanel == Panel.Panel1)
        { 
            //Panel1(北)を表示したい：Parentの位置を(-2300,0,0)  
            this.transform.localPosition = new Vector2(-2300, 0);
            modoruYajirushi.SetActive(false);
        }
        else if (nextPanel == Panel.Panel2)
        {
            //Panel2(東)を表示したい：Parentの位置を(4600,0,0)
            this.transform.localPosition = new Vector2(-4600, 0);
            modoruYajirushi.SetActive(false);
        }
        else if (nextPanel == Panel.Panel3)
        {
            //Panel3(宝箱)を表示したい：Parentの位置を(0,1300,0)
            this.transform.localPosition = new Vector2(0, 1300);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel4)
        {
            //Panel4(コーヒーメーカー)を表示したい：Parentの位置を(2300,-1300,0)
            this.transform.localPosition = new Vector2(-2300, 1300);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel5)
        {
            //Panel5(引き出し1)を表示したい：Parentの位置を(4600,-1300,0)
            this.transform.localPosition = new Vector2(-4600, 1300);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel6)
        {
            //Panel6(引き出しあける)を表示したい：Parentの位置を(0,-2600,0)
            this.transform.localPosition = new Vector2(0, 2600);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel7)
        {
            //Panel7(足跡)を表示したい：Parentの位置を(2300,-2600,0)
            this.transform.localPosition = new Vector2(-2300, 2600);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel8)
        {
            //Panel8(標本)を表示したい：Parentの位置を(4600,-2600,0)
            this.transform.localPosition = new Vector2(-4600, 2600);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel9)
        {
            //Panel9(鹿)を表示したい：Parentの位置を(0,-3900,0)
            this.transform.localPosition = new Vector2(0, 3900);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel10)
        {
            //Panel10(手帳)を表示したい：Parentの位置を(2300,-3900,0)
            this.transform.localPosition = new Vector2(-2300, 3900);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel11)
        {
            //Panel11(レコード)を表示したい：Parentの位置を(4600,-3900,0)
            this.transform.localPosition = new Vector2(-4600, 3900);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel12)
        {
            //Panel12(標本ボタンパネル)を表示したい：Parentの位置を(0, -5200,0)
            this.transform.localPosition = new Vector2(0, 5200);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel13)
        {
            //Panel13(引き出し2)を表示したい：Parentの位置を(2300, -5200,0)
            this.transform.localPosition = new Vector2(-2300, 5200);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel14)
        {
            //Panel14(引き出し2開く)を表示したい：Parentの位置を(4600, -5200,0)
            this.transform.localPosition = new Vector2(-4600, 5200);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel15)
        {
            //Panel15(引き出し3)を表示したい：Parentの位置を(0, -6500,0)
            this.transform.localPosition = new Vector2(0, 6500);
            modoruYajirushi.SetActive(true);
        }
        else if (nextPanel == Panel.Panel16)
        {
            //Panel16(引き出し3開く)を表示したい：Parentの位置を(2300, -6500,0)
            this.transform.localPosition = new Vector2(-2300, 6500);
            modoruYajirushi.SetActive(true);
        }
    }
    public void OnPanel0_nishi()
    {
        //Panel0(西)を表示したい：Parentの位置を(0,0,0)
        ShowPanel(Panel.Panel0);
    }

    public void OnPanel1_kita()
    {
        //Panel1(北)を表示したい：Parentの位置を(-2300,0,0)  
        ShowPanel(Panel.Panel1);        
    }
    public void OnPanel2_higashi()
    {
        //Panel2(東)を表示したい：Parentの位置を(4600,0,0)
        ShowPanel(Panel.Panel2);        
    }
        
    //戻る矢印
    public void OnModoruYajirushi()
    {
        //もし宝箱(Panel3)だったらPanel2を表示
        //もしコーヒーメーカー(Panel 4)だったらPanel1を表示
        //現在表示しているパネルが何なのか:変数で表示

        if (currentPanel == Panel.Panel3)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel4)
        {
            //Panel1(北)を表示
            ShowPanel(Panel.Panel1);
        }
        else if (currentPanel == Panel.Panel5)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel6)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel7)
        {
            //Panel0(西)を表示
            ShowPanel(Panel.Panel0);
        }
        else if (currentPanel == Panel.Panel8)
        {
            //Panel0(西)を表示
            ShowPanel(Panel.Panel0);
        }
        else if (currentPanel == Panel.Panel9)
        {
            //Panel0(北)を表示
            ShowPanel(Panel.Panel1);
        }
        else if (currentPanel == Panel.Panel10)
        {
            //Panel0(北)を表示
            ShowPanel(Panel.Panel1);
        }
        else if (currentPanel == Panel.Panel11)
        {
            //Panel0(北)を表示
            ShowPanel(Panel.Panel1);
        }
        else if (currentPanel == Panel.Panel12)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel13)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel14)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel15)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
        else if (currentPanel == Panel.Panel16)
        {
            //Panel2(東)を表示
            ShowPanel(Panel.Panel2);
        }
    }

    //タップしたらPanelを表示
    public void OnTakarabako()
    {
        //Panel3を表示したい：Parentの位置を(0,1300,0)
        ShowPanel(Panel.Panel3);
    }
    public void Onkohimeka()
    {
        //Panel4を表示したい：Parentの位置を(2300,-1300,0)
        ShowPanel(Panel.Panel4);
    }

    public void Onhikidashi_1()
    {
        //Panel5を表示したい：Parentの位置を(4600,-1300,0)
        ShowPanel(Panel.Panel5);
    }
    public void Onhikidashi_2()
    {
        //Panel13を表示したい：Parentの位置を(2300,-5600,0)
        ShowPanel(Panel.Panel13);
    }
    public void Onhikidashi_3()
    {
        //Panel13を表示したい：Parentの位置を(2300,-5600,0)
        ShowPanel(Panel.Panel15);
    }
    public void Onhikidashi_hiraku_1()
    {
        //Panel6(引き出し開いた)を表示したい：Parentの位置を(0,-2600,0)
        ShowPanel(Panel.Panel6);
    }
    public void Onhikidashi_hiraku_2()
    {
        //Panel6(引き出し開いた)を表示したい：Parentの位置を(0,-2600,0)
        ShowPanel(Panel.Panel14);
    }
    public void Onhikidashi_hiraku_3()
    {
        //Panel6(引き出し開いた)を表示したい：Parentの位置を(0,-2600,0)
        ShowPanel(Panel.Panel16);
    }
    public void Onashiato()
    {
        //Panel7を表示したい：Parentの位置を(2300,-2600,0)
        ShowPanel(Panel.Panel7);
    }
    public void Onhyouhon()
    {
        //Panel8を表示したい：Parentの位置を(4600,-2600,0)
        ShowPanel(Panel.Panel8);
    }
    public void Onshika()
    {
        //Panel9を表示したい：Parentの位置を(0,-3900,0)
        ShowPanel(Panel.Panel9);
    }
    public void Ontecho()
    {
        //Panel10を表示したい：Parentの位置を(0,-3900,0)
        ShowPanel(Panel.Panel10);
    }
    public void Onrekodo()
    {
        //Panel11を表示したい：Parentの位置を(4600,-3900,0)
        ShowPanel(Panel.Panel11);
    }
    public void Onhyouhon_nyuryoku()
    {
        //Panel12を表示したい：Parentの位置を(0,-5200,0)
        ShowPanel(Panel.Panel12);
    }
}
