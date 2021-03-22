using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maincamera : MonoBehaviour
{
    Transform tf; //Main CameraのTransform
    Camera cam; //Main CameraのCamera

    bool flag;
    void Start()
    {
        flag = true;
        tf = this.gameObject.GetComponent<Transform>(); //Main CameraのTransformを取得する。
        cam = this.gameObject.GetComponent<Camera>(); //Main CameraのCameraを取得する。
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && flag) //Iキーが押されていれば
        {
            cam.orthographicSize = cam.orthographicSize - 1.0f; //ズームイン。
        }
        else if (Input.GetMouseButtonDown(0)) //Oキーが押されていれば
        {
            cam.orthographicSize = cam.orthographicSize + 1.0f; //ズームアウト。
        }
    }
}
