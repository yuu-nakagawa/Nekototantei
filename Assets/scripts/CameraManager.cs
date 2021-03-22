using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Transform[] cameraTransforms;
    int currentCameraPosition;

    static public CameraManager instance;

    Camera currentCamera;
    Camera mainCamera;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void setZoomCamera(Camera camera)
    {
        camera.gameObject.SetActive(true);
        Camera.main.gameObject.SetActive(false);
        currentCamera = camera;
    }

    public void backMainCamera()
    {
        currentCamera.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);
    }
}
