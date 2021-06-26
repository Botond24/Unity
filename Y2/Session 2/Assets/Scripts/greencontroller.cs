using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class greencontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public Rigidbody rb;
    public Vector2 movement;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void FixedUpdate(){
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 dir){
        rb.velocity = dir*speed;
    }
}
