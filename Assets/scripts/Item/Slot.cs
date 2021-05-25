using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    //�A�C�e��(�f�[�^)���󂯎�邽�߂ɕϐ���p�ӂ���
    Item item;
    // �A�C�e�����󂯎������摜���X���b�g�ɕ\�����Ă��
    [SerializeField] Image image;
    [SerializeField] GameObject backgroundPanel;
    private void Awake()
    {
        //image = GetComponent<Image>();
    }

    private void Start()
    {
        backgroundPanel.SetActive(true);
    }

    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }
    public void SetItem(Item item)
    {
        //�A�C�e��(�f�[�^)����������
        this.item = item;
        UpdataImage(item);
    }
    public Item GetItem()
    {
        return item;
    }
    //�A�C�e�����󂯎������摜���X���b�g�ɕ\�����Ă��
    void UpdataImage(Item item)
    {
        if (item == null)
        {
            image.sprite = null;
        }
        else
        {
            image.sprite = item.sprite;
        }
    }
    
    public bool OnSelected()
    {
        if (item == null)
        {
            return false;
        }
        backgroundPanel.SetActive(false);
        return true;
     }

    public void HideBGPanel()
     {
    backgroundPanel.SetActive(true);
     }
}
