using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Controller : MonoBehaviour
{
    private float Vertical;
    private float Horizontal;

    public Rigidbody2D Rigidbody;


    private void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Rigidbody.AddRelativeForce(new Vector2(Horizontal, Vertical));  
    }

}   
    
