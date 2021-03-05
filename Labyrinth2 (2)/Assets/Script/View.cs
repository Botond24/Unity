using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class View : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.rotation = player.transform.rotation;

    } 
    public GameObject player;
    public float x;
    public float z;
    public float y;
    void Update()
    {
        // Temporary vector
        Vector3 temp = player.transform.position;
        temp.x = temp.x - x;
        temp.y = y;
        temp.z = temp.z - z;
        // Assign value to Camera position
        transform.position = temp;

    }
}
