using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float mouseSensitivity = 100f;  
    private float xRotation = 0f;          
    private float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        xRotation = 0f;  // ���� ������ �������� �����
        yRotation = transform.eulerAngles.y;  // ��������� ������� ����
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // �������� �������� ���� �� ��� X
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // �������� �������� ���� �� ��� Y

        
        yRotation += mouseX; // ������� �� ��� Y


        xRotation -= mouseY; // ������� �� ��� X
        xRotation = Mathf.Clamp(xRotation, -70f, 65f); // ������������ ���� ������� �� ��� X

       
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);  // ��������� �������� �� ���� X � Y
    }
}
