using UnityEngine;

public class Brick : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D ball)
    {
        Destroy(gameObject);
        FindObjectOfType<BrickManager>().RemoveBrick(this);
    }
}
