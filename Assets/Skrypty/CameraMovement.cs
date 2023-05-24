using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Camera;
    public float Sensitivity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        float MouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        transform.Rotate(Vector3.up * MouseX);
    }
}
