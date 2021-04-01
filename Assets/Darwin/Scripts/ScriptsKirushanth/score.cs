using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Transform ts;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("z position is: " +ts.position.z);
        scoreText.text = ts.position.z.ToString("0"); //Convert.ToString(ts.position.z); "0" to remove decimal places


    }
}
