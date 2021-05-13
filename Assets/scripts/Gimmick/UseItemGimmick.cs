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
}
