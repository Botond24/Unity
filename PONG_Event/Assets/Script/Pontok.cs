using UnityEngine;
using UnityEngine.UI;

public class Pontok : MonoBehaviour
{
    public Text text;
    private int points;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Labda")
        {
            points++;
            text.text = points.ToString();
        }
    }
}
