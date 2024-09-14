using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float runMultiplier = 1.5f;
    public float thrust = 20f;

    public Transform playerCamera; // —сылка на камеру
    private Rigidbody rb; // —сылка на компонент Rigidbody
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = (playerCamera.forward * verticalInput) + (playerCamera.right * horizontalInput);
        direction.y = 0; 

        float currentSpeed = movementSpeed;
        if (Input.GetKey(KeyCode.LeftShift))
            currentSpeed *= runMultiplier;
        rb.MovePosition(transform.position + direction.normalized * currentSpeed * Time.deltaTime);
        
    }
}
