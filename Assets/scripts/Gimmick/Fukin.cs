using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fukin : MonoBehaviour
{
    //�A�C�e���̕\���E��\��
    public GameObject Fukin_A1;
    public GameObject Fukin_A;

    //�z��A1���^�b�v������A�z��A1���\���A�z��A��\������
    //�E�^�C�~���O�F�N���b�N�����Ƃ�
    //�E�����F�z��A1���\��
    //�E�����F�z��A��\������

    //�E�^�C�~���O�F�N���b�N�����Ƃ�

    public void OnFukin()
    {
        //�����F�z��A1���\��
        Fukin_A1.SetActive(false);
        //�z��A��\������
        Fukin_A.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
