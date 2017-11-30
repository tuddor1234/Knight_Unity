using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 6f;
    public float turnVel = 12f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRayLenght = 100f;
    float horizontalInput, verticalInput;
   


    private void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        //SCHIMBA PENTRU JOYSTICK
        GetInput();
        Animating(horizontalInput, verticalInput);
        Move(horizontalInput, verticalInput);
    }

    private void Update()
    {
        Turn(horizontalInput, verticalInput);
    }

    void GetInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }


    void Move(float h,float v)
    {
        movement.Set(h, 0, v);
        movement = movement.normalized * speed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Turn(float h, float v)
    {
        // ADD ROTATION


    }

    void Animating(float h,float v)
    {
        bool walking = h != 0f || v != 0f;
        anim.SetBool("IsWalking",walking);
    }





}
