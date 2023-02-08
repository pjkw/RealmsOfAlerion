using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] Camera camera;

    void Start()
    {
        SetupCamera();
    }

    void SetupCamera()
    {
        camera.orthographic = true;
        camera.orthographicSize = 5;
    }
}