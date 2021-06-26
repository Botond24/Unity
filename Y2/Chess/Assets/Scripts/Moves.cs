using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    private Camera Cam;
    void Start() {
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
    void OnMouseUp()
    {
        transform.position = GetClosest(GameObject.Find("Board").GetComponent<GenerateBoard>().BPs).position - new Vector3(0,0,1);
        transform.GetComponent<SpriteRenderer>().size = new Vector2(2,2);
    }
    Transform GetClosest(List<Transform> BP)
    {
        Transform T = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform tr in BP)
        {
            float dist = Vector3.Distance(tr.position, currentPos);
            if (dist < minDist)
            {
                T = tr;
                minDist = dist;
            }
        }
        return T;
    }
}
