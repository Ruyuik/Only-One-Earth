using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    [SerializeField]
    [Range(-10, -3)]
    float cameraZoom = -6f;

    [SerializeField]
    float zoomSpeed = 0.25f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y != 0)
        {
            cameraZoom += Input.mouseScrollDelta.y * zoomSpeed;
            cameraZoom = Mathf.Clamp(cameraZoom, -10f, -4f);
        }

        transform.position = new Vector3(0, 0, cameraZoom);
    }
}
