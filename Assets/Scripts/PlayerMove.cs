using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    public CharacterController controller;
    public float speed =10;
    public float gravity = -9.81f;
    public float groundDistance = 0.4f;
    public float jumpHeight = 4f;

    public Transform groundCheck;
    Vector3 velocity;

    public LayerMask groundMask;
    public bool isGrounded;

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(Input.GetKeyDown(KeyCode.Space)  && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
