using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAndPlace : MonoBehaviour
{
    public Camera Cam;
    void OnMouseDrag() {
        transform.position = new Vector3(
            Cam.ScreenToWorldPoint(Input.mousePosition).x,
            Cam.ScreenToWorldPoint(Input.mousePosition).y,
            0
        );
    }
}
