using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : MonoBehaviour
{
    float forwardInput;
    float steeringInput;
    public float forwardSpeed = 500;
    public float steeringSpeed = 200;
    Rigidbody2D rigidbody;
    public float maxSpeed = 450;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        steeringInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rigidbody.AddTorque(steeringInput * -steeringSpeed * Time.deltaTime);
        Vector2 force = transform.up * forwardInput * forwardSpeed * Time.deltaTime;
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(force);
        }
    }


}
