using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawerscript : MonoBehaviour
{
    [SerializeField] GameObject hikidashi_1Panel;
    
    void Start()
    {
        hikidashi_1Panel.SetActive(false);
    }

    //引き出しが押されたら
    public void OnClickTrigger()
    {
        hikidashi_1Panel.SetActive(true);

    }
}
