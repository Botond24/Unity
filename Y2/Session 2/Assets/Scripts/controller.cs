using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            Debug.Log("space was pressed");
        }
        if (Input.GetKey(KeyCode.W)){
            player.position = transform.position + new Vector3(0, 1, 0)*speed/100;
        }
        if (Input.GetKey(KeyCode.A)){
            player.position = transform.position + new Vector3(-1, 0, 0)*speed/100;
        }
        if (Input.GetKey(KeyCode.S)){
            player.position = transform.position + new Vector3(0, -1, 0)*speed/100;
        }
        if (Input.GetKey(KeyCode.D)){
            player.position = transform.position + new Vector3(1, 0, 0)*speed/100;
        }
    }
}
