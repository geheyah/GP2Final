using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class CCScript : MonoBehaviour
{
    [SerializeField]private CharacterController controller;
    [SerializeField]private float speed = 1.0f;
    [SerializeField]private float jumpHeight = 1.0f;
    [SerializeField]private float gravity = -3f;
    [SerializeField]private bool isJumping;
    [SerializeField]private Vector3 velocity;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Character Controller

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveHorizontal + transform.forward * moveVertical;

        // gravity

        // jump
        if (controller.isGrounded)
        {
            if (isJumping)
            {
                isJumping = false;
                velocity.y = 0f;
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                isJumping = true;

                velocity.y = 0;
                velocity.y += (jumpHeight);
            }

        }
        else if (Input.GetKeyUp(KeyCode.Space) && velocity.y > 0)
        {
            velocity.y *= 0.5f;
        }
        else if (!controller.isGrounded) 
        {
            velocity.y += Physics.gravity.y * Time.deltaTime;
        }
        //rotate
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * 100, Space.World);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, -1, 0) * Time.deltaTime * 100, Space.World);
        }

        controller.Move(((move * speed) + velocity) * Time.deltaTime);
    }
    
}





