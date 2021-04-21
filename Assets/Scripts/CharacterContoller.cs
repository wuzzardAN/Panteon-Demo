using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour
{
    
    private InputManager inputManager;
    private Vector3 moveDir;
    private Transform cameraObject;
    private Rigidbody rb;

    

    public float movementSpeed = 2f;
    public float rotationSpeed = 5f;
    
    private void Awake()
    {
        
        rb = GetComponent<Rigidbody>();
        inputManager = GetComponent<InputManager>();
        cameraObject = Camera.main.transform;
    }

    public void HandleAllMovement()
    {
        
        HandleMovement();
        HandleRotation();
    }
    private void HandleMovement()
    {
        moveDir = cameraObject.forward * inputManager.verticalInput;
        moveDir = moveDir + cameraObject.right * inputManager.horizontalInput;
        moveDir.Normalize();
        moveDir.y = 0;
        moveDir = moveDir * movementSpeed;

        Vector3 movementVelocity = moveDir;
        rb.velocity = movementVelocity;
    }

    private void HandleRotation()
    {
        Vector3 targetDirection = Vector3.zero;
        targetDirection = cameraObject.forward * inputManager.verticalInput;
        targetDirection = targetDirection + cameraObject.right * inputManager.horizontalInput;
        targetDirection.Normalize();
        targetDirection.y = 0;

        if (targetDirection == Vector3.zero)
        {
            targetDirection = transform.forward;
        } 
        
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        Quaternion playerRotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.rotation = playerRotation;
    }

    
}
