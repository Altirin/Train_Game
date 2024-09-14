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
        xRotation = 0f;  // Чтобі камера смотрела прямо
        yRotation = transform.eulerAngles.y;  // Применяем текущий угол
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // отслежую полворот мыши по оси X
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // отслежую полворот мыши по оси Y

        
        yRotation += mouseX; // Поворот по оси Y


        xRotation -= mouseY; // Поворот по оси X
        xRotation = Mathf.Clamp(xRotation, -70f, 65f); // Ограничиваем угол наклона по оси X

       
        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);  // Применяем вращение по осям X и Y
    }
}
