using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kagi : MonoBehaviour
{
    //�A�C�e���̕\���E��\��
    public GameObject KagiA1;
    public GameObject KagiA;

    //��A1���^�b�v������A��A1���\���A��A��\������
    //�E�^�C�~���O�F�N���b�N�����Ƃ�
    //�E�����F��A1���\��
    //�E�����F��A��\������

    //�E�^�C�~���O�F�N���b�N�����Ƃ�
  
    public void OnKagiA()
    {
        //�����F��A1���\��
        KagiA1.SetActive(false);
        //��A��\������
        KagiA.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
