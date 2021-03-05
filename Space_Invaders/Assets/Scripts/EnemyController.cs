using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public int rows;
    public int columns;
    public float spacing;
    public GameObject enemyPrefab;
    public Text txt;
    public float animSpeed;
    public GameObject player;
    public GameObject playerPrefab;
    private List<GameObject> enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        ResetLevel();
    }
    void Update()
    {
        if (enemies.Count == 0)
        {
            Win();
        }
        transform.Translate(Vector2.down * animSpeed);
        if (player == null)
        {
            Lose();
        }
        /*
        switch (anim)
        {
            case 1:
                if(nextAnim * animSpeed <=1)
                {
                    transform.position = Vector2.Lerp(transform.position, new Vector2(-3,transform.position.y), nextAnim*animSpeed);
                }
                else
                {
                    nextAnim = 0;
                    anim = 2;
                }
                nextAnim += 0.1f;
                break;
            case 2:
                if(nextAnim * animSpeed <=1)
                {
                    transform.position = Vector2.Lerp(transform.position, new Vector2(-3,transform.position.y -0.001f), nextAnim * animSpeed*2);
                }
                else
                {
                    nextAnim = 0;
                    anim = 3;
                }
                nextAnim += 0.1f;
                break;
            case 3:
                if(nextAnim * animSpeed <=1)
                {
                    transform.position = Vector2.Lerp(transform.position, new Vector2(-3.6f,transform.position.y), nextAnim * animSpeed);
                }
                else
                {
                    nextAnim = 0;
                    anim = 4;
                }
                nextAnim += 0.1f;
                break;
            case 4:
                if(nextAnim * animSpeed <=1)
                {
                    transform.position = Vector2.Lerp(transform.position, new Vector2(-3.6f,transform.position.y -0.001f), nextAnim * animSpeed*2);
                }
                else
                {
                    nextAnim = 0;
                    anim = 1;
                }
                nextAnim += 0.1f;
                break;
        }
        */
    }
    public void ResetLevel()
    {
        player = Instantiate(playerPrefab, new Vector2(0,0), Quaternion.identity);
        transform.position = new Vector2(-3.25f, 4);
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();

        for (int j = 0; j < rows; j++)
        {
            for (int i = 0; i < columns; i++)
            {
                Vector2 spawn = (Vector2)transform.position + new Vector2(
                    i * (enemyPrefab.transform.localScale.x+spacing),
                    -j * (enemyPrefab.transform.localScale.y+spacing)
                );
                GameObject enemy = Instantiate(enemyPrefab, spawn, Quaternion.identity);
                enemy.transform.parent = this.transform;
                enemies.Add(enemy);
            }
        }
    }

    public void Lose()
    {
        txt.text = "You Lost! Press E to restart!";
        if (Input.GetKey("e"))
        {
            ResetLevel();
            txt.text = "";
        }
        
    }
    public void Win()
    {
        txt.text = "You Won! Press E to restart!";
        if (Input.GetKey("e"))
        {
            Destroy(player);
            ResetLevel();
            txt.text = "";
        }
        
    }
    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy.gameObject);
        if (enemies.Count == 0)
        {
            Win();
        }
    }
}
