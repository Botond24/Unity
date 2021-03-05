using UnityEngine;

public class Uto_1_mozgas : MonoBehaviour
{   
    private Rigidbody rb;
    public float PlayerSpeed1;
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
            rb.velocity = new Vector2(0, PlayerSpeed1);
        }
        else if (Input.GetKey("s"))
        {
            rb.velocity = new Vector2(0,-PlayerSpeed1);
        }
        else
        {
            rb.velocity = new Vector2(0,0);
        }
    }
}
