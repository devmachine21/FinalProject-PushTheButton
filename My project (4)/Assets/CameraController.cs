using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraScaler : MonoBehaviour
{
    public float defaultWidth = 10f; // Set your desired width in game units
    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        AdjustCamera();
    }

    void AdjustCamera()
    {
        float currentAspect = (float)Screen.width / Screen.height;
        // Calculate the new orthographic size (height) needed to maintain the default width
        cam.orthographicSize = defaultWidth / currentAspect / 2f;
    }
}