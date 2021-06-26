using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube1 : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (Input.inputString)
        {
            case "w":
                transform.position += new Vector3(0,1,0) * speed;
                break;
            case "a":
                transform.position += new Vector3(-1,0,0) * speed;
                break;
            case "s":
                transform.position += new Vector3(0,-1,0) * speed;
                break;
            case "d":
                transform.position += new Vector3(1,0,0) * speed;
                break;
            default:
                break;
        }
    }
}
