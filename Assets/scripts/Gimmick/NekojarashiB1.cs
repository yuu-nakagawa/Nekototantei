using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekojarashiB1 : MonoBehaviour
{
    //�A�C�e���̕\���E��\��
    public GameObject Nekojarashi_B1;
    public GameObject Nekojarashi_B;

    //�L����炵B1���^�b�v������A�L����炵B1���\���A�L����炵B��\������
    //�L����炵B1���^�b�v������A�L����炵B1���\���A�L����炵B��\������
    //�E�^�C�~���O�F�N���b�N�����Ƃ�
    //�E�����F�L����炵B1���\��
    //�E�����F�L����炵B��\������

    //�E�^�C�~���O�F�N���b�N�����Ƃ�
    public void OnNekojarashiB()
    {
        //�����F�L����炵B1���\��
        Nekojarashi_B1.SetActive(false);
        //�L����炵B��\������
        Nekojarashi_B.SetActive(true);
        GameObject.Find("ModoruYajirushi").SetActive(false);
    }
}
