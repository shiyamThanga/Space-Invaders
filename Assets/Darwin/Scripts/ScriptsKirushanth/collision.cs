using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class collision : MonoBehaviour
{
    public playerMovement movement;
    // Start is called before the first frame updates
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision target)
    {
        if(target.collider.tag == "Obstacles")
        {
            Debug.Log("collided with an object: " +target.collider.name);
            //FindObjectOfType<gameManager1>().GameOver();

        }
    }
}
