using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomcamera : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;
    public void onClickThis()
    {
        //Camera�Y�[������̂��Ăяo��
        CameraManager.instance.setZoomCamera(zoomCamera);
    }
}
