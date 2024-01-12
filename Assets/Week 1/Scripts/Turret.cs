using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    float speed = 30f;
  
    void Start()
    {
        
    }

   
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate( 0,  0, direction * speed * Time.deltaTime);
    }
}
