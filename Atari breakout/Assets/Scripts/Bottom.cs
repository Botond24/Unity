﻿
using UnityEngine;

public class Bottom : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        other.GetComponent<Ball>().Respawn();
    }
}
