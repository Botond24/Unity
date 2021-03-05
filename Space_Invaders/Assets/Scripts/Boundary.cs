using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class Boundary : MonoBehaviour
{
    //public Enemy Enemy;
    void OnTriggerExit2D(Collider2D other)
    {
        /*
        if(other == Enemy.Collider2D)
        {
            FindObjectOfType<EnemyController>().ResetLevel();
        }
        */
        Destroy(other.gameObject);
    }
}
