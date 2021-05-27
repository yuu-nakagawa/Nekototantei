using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseItemGimmick : MonoBehaviour
{
    //��肽������
    //�A�C�e���˂�����炵�������Ă����ԂŁA�N���b�N����Ə�����
    //�E�N���b�N����
    //�E�A�C�e�������Ă܂��攻��
    [SerializeField] Item.Type clearItem;

    public void OnClickObj()
    {
        //Debug.Log("�N���b�N������");
        //�A�C�e���L����炵�������Ă��邩�ǂ���
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if(clear == true)
        {
            //Debug.Log("�M�~�b�N����");
            gameObject.SetActive(false);
        }
    }

    public void OnClicktecho()
    {
        //�A�C�e�����������Ă��邩�ǂ���
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            gameObject.SetActive(false);
            //�蒠���J�����p�l����\������
            GameObject.Find("Panel10").transform.Find("techohiraku_Panel").gameObject.SetActive(true);
            //�蒠�{�^�����\���ɂ���
            GameObject.Find("techobutton").gameObject.SetActive(false);
            //�蒠�J���p�l����\���ɂ���
            GameObject.Find("kitaPanel").transform.Find("techo_akibutton").gameObject.SetActive(true);
        }
    }
    
    public void Ithibyou()
    {
        GameObject.Find("rekodo_totteariPanel").gameObject.SetActive(false);
        GameObject.Find("Panel11").transform.Find("rekodo_hintoPanel").gameObject.SetActive(true);
    }
    public void OnClickrekodo()
    {
        //Debug.Log("�N���b�N������");
        //�A�C�e�������������Ă��邩�ǂ���
        bool clear = ItemBox.instance.TryUseItem(clearItem);
        if (clear == true)
        {
            gameObject.SetActive(false);
            //������t�����p�l����\������
            GameObject.Find("Panel11").transform.Find("rekodo_totteariPanel").gameObject.SetActive(true);
            Invoke("Ithibyou", 1.5f);
        }
    }
}
