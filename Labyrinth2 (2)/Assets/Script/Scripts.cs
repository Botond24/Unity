using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    public void Exit()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void Cursor_Disable()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void LoadScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
