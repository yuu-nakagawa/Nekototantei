using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomcamera : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;
    public void onClickThis()
    {
        //CameraƒY[ƒ€‚·‚é‚Ì‚ğŒÄ‚Ño‚·
        CameraManager.instance.setZoomCamera(zoomCamera);
    }
}
