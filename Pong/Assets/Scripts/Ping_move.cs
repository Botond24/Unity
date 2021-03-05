using UnityEngine;

public class Ping_move : MonoBehaviour
{
    private Rigidbody rb;
    public float ps;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector2(0, ps);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0, -ps);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
