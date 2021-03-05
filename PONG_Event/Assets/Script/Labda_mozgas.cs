using System.Collections;
using UnityEngine;

public class Labda_mozgas : MonoBehaviour
{
    private Rigidbody rb;
    public float LabdaSpeed;
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
                rb.velocity = new Vector2(-5,5);
                break;
            case 3:
                rb.velocity = new Vector2(5,-5);
                break;
            case 4: 
                rb.velocity = new Vector2(-5,-5);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude < LabdaSpeed || rb.velocity.magnitude > LabdaSpeed)
        {
            rb.velocity =rb.velocity.normalized * LabdaSpeed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Respawn")
        {
            transform.SetPositionAndRotation(new Vector3(0,0,0), Quaternion.Euler(new Vector3(0,0,0)));
            StartCoroutine(Stop());
            switch (Random.Range(1,5))
            {
                case 1:
                    rb.velocity = new Vector2(5,5);
                    break;
                case 2:
                    rb.velocity = new Vector2(-5,5);
                    break;
                case 3:
                    rb.velocity = new Vector2(5,-5);
                    break;
                case 4: 
                    rb.velocity = new Vector2(-5,-5);
                    break;
            }
        }
    }

    IEnumerator Stop()
    {
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1);
        Time.timeScale = 1;
    }
}
