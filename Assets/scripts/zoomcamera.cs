using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomcamera : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;
    public void onClickThis()
    {
        //Cameraズームするのを呼び出す
        CameraManager.instance.setZoomCamera(zoomCamera);
    }
}
