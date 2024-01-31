using Unity.VisualScripting;
using UnityEngine;

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
        Debug.Log("Welcome to the trampoline park! Your goal is it collect coins! :)"); 
        Debug.Log("Hold the down arrow key to charge and release to jump! Use the left and right arrow keys to move side to side. You can also hold the spacebar to unleash a slow down move to help collect coins!");
    }

    void Update()
    {
        direction.x = Input.GetAxis("Horizontal"); //changes the x direction of the player 
        transform.Translate(direction * speed * Time.deltaTime); //translates the player by speed. (translate gives it a more 'snappier' feeling compared to force)

        if (Input.GetKey(KeyCode.DownArrow)) //if the down arrow is pressed down
        {
            if (force < 300) //and if the force is still less than 500
            {
                force += 300 * Time.deltaTime; //building up force for the jump
            }
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) && transform.position.y < -2) //when the user releases the down arrow and it is near the trampoline
        {
            rigidbody.AddForce(jumpDirection * force); //adding jump force to the player. It does not need deltatime because it doesn't need to constantly add a force (only adds once)
            force = 0; //reset the force back to 0
            
        }

        if(Input.GetKey(KeyCode.Space) && rigidbody.velocity.y <= 0) //when you press space and the player is falling
        {
            rigidbody.gravityScale = 0.2f; //lower gravity to slow the fall
        }

        if (Input.GetKeyUp(KeyCode.Space)) //when releasing space key
        {
            rigidbody.gravityScale = 1f; //change it back to normal
        }
    }

    


}
