using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0,speed);;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
