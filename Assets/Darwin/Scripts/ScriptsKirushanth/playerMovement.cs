using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 500f; //will be updated in the script tab on unity
    public float sideWayForce = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game start Log 123");
        //rb.useGravity = false; //Disable gravity using programming
        //rb.AddForce(0, 0, 200 * Time.deltaTime); //deltaTime = 1 / fps ---> make sure object moves 1 unit
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(0, 0, force * Time.deltaTime);
        //rb

        //Assigning controls
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //4th argument adds the instanct velocity change
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if(rb.position.y < -15)
        {
            FindObjectOfType<gameManager1>().GameOver();
        }

    }
}
