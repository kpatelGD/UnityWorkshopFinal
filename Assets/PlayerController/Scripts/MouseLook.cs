﻿using UnityEngine;

public class MouseLook : MonoBehaviour
{
#pragma warning disable 649

    [SerializeField] float sensitivityX = 150f;
    [SerializeField] float sensitivityY = 0.2f;
    float mouseX, mouseY;

    [SerializeField] Transform playerCamera;
    [SerializeField] float xClamp = 85f;
    float xRotation = 0f;

    private void Start()
    {
        
    }

    private void Update()
    {
        if(PauseMenu.isPaused == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
            transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
            Vector3 targetRotation = transform.eulerAngles;
            targetRotation.x = xRotation;
            playerCamera.eulerAngles = targetRotation;
        }

        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        

    }

    public void ReceiveInput(Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        mouseY = mouseInput.y * sensitivityY;
    }

}