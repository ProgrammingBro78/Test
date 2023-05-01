using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 300f;
    public Transform playerBody;
    float xRotation = 0f;


    float playerbody;
    float pla
    // Start is called before the first 1 update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        
        
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);
            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
   
       
`           playerBody.transform.localRoat

    }
}
