using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

/**
 * This class is responsible for all player actions.
 */
public class TrampolinePlayer : MonoBehaviour
{
    Vector2 direction; //this is only used for the horizontal direction of the player
    Vector2 jumpDirection; //this is only used to control the jump
    Rigidbody2D rigidbody;
    public float speed = 15;
    public float force = 0;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); //referencing to the rigidbody2D component 
        jumpDirection.y = 1; //making the jump direction up
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal"); //changes the x direction of the player 
        transform.Translate(direction * speed * Time.deltaTime); //translates the player by speed. (translate gives it a more 'snappier' feeling compared to force)

        if (Input.GetKey(KeyCode.DownArrow)) //if the down arrow is pressed down
        {
            if (force < 500) //and if the force is still less than 500
            {
                force += 40 * Time.deltaTime; //building up force for the jump
            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) //when the user releases the down arrow
        {
            rigidbody.AddForce(jumpDirection * force); //adding jump force to the player. It does not need deltatime because it doesn't need to constantly add a force (only adds once)
            force = 0; //reset the force back to 0
            
        }
    }

}
