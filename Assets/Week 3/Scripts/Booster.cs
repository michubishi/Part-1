using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    public Car car;
    Rigidbody2D rigidbody;
    void Start()
    {
        rigidbody = car.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector2 force = car.transform.up * car.forwardSpeed * Time.deltaTime * 50;
        rigidbody.AddForce(force);
    }
}
