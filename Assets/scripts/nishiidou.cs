using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class nishiidou : MonoBehaviour
{
    //ボタンをクリックしたら
    public void OnClick()
    {
        //西の画面へ移動
        SceneManager.LoadScene("higashi");
    }
}
