using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialNumber : MonoBehaviour
{
    [SerializeField] TMP_Text numberText;   //�\�����邽�߂̂���
    int number = 0;   //����

    //�N���b�N�����Ɛ����𑝂₷
    public void Onclick()
    {
        number++;
        numberText.text = number.ToString();
    }
}
