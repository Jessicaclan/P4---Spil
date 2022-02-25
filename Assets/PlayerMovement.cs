using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D Controller;

    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    bool crouch = false;
 

    // Update is called once per frame
    void Update()
    {


        //Function to make the player move from left to right
        horizontalMove = Input.GetAxisRaw("HorizontalPlayer1") * runSpeed;



        //Function to make the player jump
        if (Input.GetButtonDown("JumpPlayer1")) 
        {
            jump = true;
                
        }



        //Function to make the player crouch
        if (Input.GetButtonDown("CrouchPlayer1")) {
            crouch = true;
        } else if (Input.GetButtonUp("CrouchPlayer1"))
        {
            crouch = false;
        }

    }

   


    //Fixed update is called a fixed amount of times
    void FixedUpdate()
    {
        Controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;

        
    }
}
