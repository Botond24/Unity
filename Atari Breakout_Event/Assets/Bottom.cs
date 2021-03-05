using UnityEngine;

public class Bottom : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ball)
    {
        ball.GetComponent<Ball>().Respawn();
    }
}
