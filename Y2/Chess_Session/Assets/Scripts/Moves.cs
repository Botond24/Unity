using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    private Camera Cam;
    // Start is called before the first frame update
    void Start()
    {
        Cam = Camera.main;
    }

    void OnMouseDrag() {
        transform.GetComponent<SpriteRenderer>().size = new Vector2(2.1f,2.1f);
        transform.position = new Vector3(
            Cam.ScreenToWorldPoint(Input.mousePosition).x,
            Cam.ScreenToWorldPoint(Input.mousePosition).y,
            -1.1f
        );
    }
    void OnMouseUp() {
        transform.position = GetClosest(GameObject.Find("Board").GetComponent<GenerateBoard>().BPs).position - new Vector3(0,0,1);
        transform.GetComponent<SpriteRenderer>().size = new Vector2(2,2);
    }

    Transform GetClosest(List<Transform> BPs)
    {
        Transform T = null;
        float minDist = Mathf.Infinity;
        foreach (Transform tr in BPs)
        {
            float dist = Vector3.Distance(tr.position, transform.position);
            if (dist < minDist)
            {
                T = tr;
                minDist = dist;
            }
        }
        return T;
    }
}
