using UnityEngine;

public class Pong_move : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    public float ps;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, ps);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -ps);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}
