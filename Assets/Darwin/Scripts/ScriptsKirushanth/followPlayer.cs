using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Transform playerPos; //refer any objects that we provide, in this case - Player
    public Vector3 vec; //3-axis
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(playerPos.position);
        transform.position = playerPos.position + vec;//just changing y ad z positions, values changed in unity
    }
}
