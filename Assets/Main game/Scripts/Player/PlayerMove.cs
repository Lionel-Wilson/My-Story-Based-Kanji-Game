using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMove : MonoBehaviour
{

    public bool CanMove;
    
    [SerializeField] private string horizontalInputName = "Horizontal";
    [SerializeField] private string verticalInputName = "Vertical";

    [SerializeField] private float movementSpeed = 2f;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        CanMove = true;
    }

    private void Update()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        
        if(CanMove == true)
        {
            movementSpeed = 2f;
            float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;     //CharacterController.SimpleMove() applies deltaTime
            float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

            Vector3 forwardMovement = transform.forward * vertInput;
            Vector3 rightMovement = transform.right * horizInput;

            //simple move applies delta time automatically
            charController.SimpleMove(forwardMovement + rightMovement);
        }
        else
        {
            movementSpeed = 0f;
            float vertInput = Input.GetAxis(verticalInputName) * movementSpeed;     //CharacterController.SimpleMove() applies deltaTime
            float horizInput = Input.GetAxis(horizontalInputName) * movementSpeed;

            Vector3 forwardMovement = transform.forward * vertInput;
            Vector3 rightMovement = transform.right * horizInput;

            //simple move applies delta time automatically
            charController.SimpleMove(forwardMovement + rightMovement);
        }
        
      
    }

    
}
