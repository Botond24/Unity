using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject shoot;
    public float speed;
    public float minx = 3.72f;
    public float fireRate;
    private float nextFire;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKey("space") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shoot, new Vector2(rb.position.x+0.3f,rb.position.y+0.7f), Quaternion.Euler(0,0,0));
        }
    }
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector2 LeftRight = new Vector2(horizontal*speed,0);

        rb.velocity = LeftRight;
        
        rb.position = new Vector2(Mathf.Clamp(rb.position.x, -minx, minx-0.58f),-4.8f);

    }
}