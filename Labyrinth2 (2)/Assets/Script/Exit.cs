using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public void Exit_s()
    {
        Debug.Log("Exited");
        Application.Quit();
    }
}
