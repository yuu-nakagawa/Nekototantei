using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialNumber : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;   //表示するためのもの
    int number = 0;   //数字

    //クリックされると数字を増やす
    public void Onclick()
    {
        number++;
        numberText.text = number.ToString();
    }
}
