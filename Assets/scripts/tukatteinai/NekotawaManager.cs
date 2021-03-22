using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NekotawaManager : MonoBehaviour
{
    [SerializeField] Sprite nekoON;
    [SerializeField] Sprite nekoOFF;
    [SerializeField] Image image;

    public void NekoSwitch(bool isON)
    {
        if (isON)
        {
            image.sprite = nekoON;
        }
        else
        {
            image.sprite = nekoOFF;
        }
    }
}
