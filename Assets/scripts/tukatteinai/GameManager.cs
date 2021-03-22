using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PANEL
{
    HIGASHIPANEL,
    JIN_NEKO_PANEL,
    HIKIDASHI_1PANEL,
    HIKIDASHI_2PANEL,
    HIKIDASHI_3PANEL
}
public class GameManager : MonoBehaviour
{
    //各パネルを取得
    public GameObject hikidashi_1Panel;
    public GameObject hikidashi_2Panel;
    public GameObject hikidashi_3Panel;
    public GameObject jin_neko_Panel;

    //現在表示しているパネル
    public PANEL currentPanel = PANEL.HIGASHIPANEL;

    //ボタンを押したら該当するパネルを表示
    public void OnClickhikidashi_1Trigger()
    {
        currentPanel = PANEL.HIKIDASHI_1PANEL;
        hikidashi_1Panel.SetActive(true);
    }
    public void OnClickhikidashi_2Trigger()
    {
        currentPanel = PANEL.HIKIDASHI_2PANEL;
        hikidashi_2Panel.SetActive(true);
    }
    public void OnClickhikidashi_3Trigger()
    {
        currentPanel = PANEL.HIKIDASHI_3PANEL;
        hikidashi_3Panel.SetActive(true);
    }

    public void OnClickjin_neko_PanelTrigger()
    {
        currentPanel = PANEL.JIN_NEKO_PANEL;
        jin_neko_Panel.SetActive(true);
    }
    //ボタンを押したらパネルを全て非表示
    public void OnClickBackTrigger()
    {
        currentPanel = PANEL.HIGASHIPANEL;
        hikidashi_1Panel.SetActive(false);
        hikidashi_2Panel.SetActive(false);
        hikidashi_3Panel.SetActive(false);
        jin_neko_Panel.SetActive(false);
    }
}
