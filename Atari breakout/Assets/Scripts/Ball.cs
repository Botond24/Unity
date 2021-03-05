using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Respawn();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < speed || rb.velocity.magnitude > speed)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
    }

    public void Respawn()
    {
        transform.position = Vector3.zero;
        //rb.velocity = Random.insideUnitCircle.normalized * speed;
        switch (Random.Range(1,5))
        {
            
            case 1:
                rb.velocity = new Vector2(5,5);
                break;
            case 2:
                rb.velocity = new Vector2(5,-5);
                break;
            case 3:
                rb.velocity = new Vector2(-5,5);
                break;
            case 4:
                rb.velocity = new Vector2(-5,-5);
                break;
        }
        FindObjectOfType<BrickManager>().ResetLevel();
    }

}
