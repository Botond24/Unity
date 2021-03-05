using UnityEngine;
using System.Collections;

public class Ball_move : MonoBehaviour
{
    private Rigidbody rb;
    public float c;
    private

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
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
        //rb.velocity = new Vector2(Random.Range(-7,7),Random.Range(-5,5));
    }

    void Update()
    {
        if (rb.velocity.magnitude < c || rb.velocity.magnitude > c)
        {
            rb.velocity = rb.velocity.normalized * c;
        }
    }

    //Respawn
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Respawn") 
        {
            transform.SetPositionAndRotation(new Vector3(0,0,0), Quaternion.Euler(new Vector3(0,0,0)));
            StartCoroutine(Example());
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
            //rb.velocity = new Vector2(Random.Range(-7,7),Random.Range(-5,5));
        }
    }
    IEnumerator Example()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 1;
    }
}
