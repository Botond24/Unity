﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(other.gameObject);
        Destroy(gameObject);
        FindObjectOfType<EnemyController>().RemoveEnemy(this);
    }
}
