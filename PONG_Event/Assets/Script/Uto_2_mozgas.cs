using UnityEngine;

public class Uto_2_mozgas : MonoBehaviour
{
    private Rigidbody rb;
    public float PlayerSpeed2;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0, PlayerSpeed2);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0, -PlayerSpeed2);
        }
        else
        {
            rb.velocity = new Vector2(0, 0);
        }
    }
}