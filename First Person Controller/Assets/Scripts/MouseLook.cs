using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    private Vector2 lookDirection;

    public Transform playerBody;

    public float mouseSensitivity = 100f;

    public float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;

    }

    // Update is called once per frame
    void Update()
    {
        Look();

        

    }

    void OnLook(InputValue input)
    {

        lookDirection = input.Get<Vector2>();
        

    }

    private void Look()
    {
        playerBody.Rotate(Vector3.up * (lookDirection.x * mouseSensitivity * Time.deltaTime));

        xRotation -= lookDirection.y * mouseSensitivity * Time.deltaTime;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        

    }



}
