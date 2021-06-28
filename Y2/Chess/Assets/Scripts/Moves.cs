using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    private Camera Cam;
    private List<Transform> BPs = new List<Transform>();
    private List<Transform> possibleMoves = new List<Transform>();
    private List<int> s = new List<int>(){0,1,0,1,0,1,0,1,1,0,1,0,1,0,1,0,0,1,0,1,0,1,0,1,1,0,1,0,1,0,1,0,0,1,0,1,0,1,0,1,1,0,1,0,1,0,1,0,0,1,0,1,0,1,0,1,1,0,1,0,1,0,1,0};
    void Start() {
        BPs = GameObject.Find("Board").GetComponent<GenerateBoard>().BPs;
        Cam = Camera.main;
    }
    void OnMouseDown()
    {
        possibleMoves.Clear();                  //   -7, +1, +9
        string a = gameObject.name;             //   -8,  0, +8 
        int i = BPs.IndexOf(GetClosest(BPs));   //   -9, -1, +7
        if (a.Contains("K"))                    
        {
            if (0 <= i && i <= 7)
            {
                switch (i % 8)
                {
                    case 0:
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i+8]);
                        possibleMoves.Add(BPs[i+9]);
                        break;
                    case 7:
                        possibleMoves.Add(BPs[i+8]); //   -7, +1, +9]);
                        possibleMoves.Add(BPs[i-1]); //   -8,  0, +8]);
                        possibleMoves.Add(BPs[i+7]); //   -9, -1, +7
                        break;
                    default:
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i+9]);
                        possibleMoves.Add(BPs[i+8]);
                        possibleMoves.Add(BPs[i-1]);
                        possibleMoves.Add(BPs[i+7]);
                        break;
                }
            }else if (56 <= i && i <= 63)
            {
                switch (i % 8)
                {
                    case 0:
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i-7]);
                        break;
                    case 7:
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i-9]);
                        possibleMoves.Add(BPs[i-1]); 
                        break;
                    default:
                        possibleMoves.Add(BPs[i-7]);
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i-9]);
                        possibleMoves.Add(BPs[i-1]);
                        break;
                }
            }else
            {
                switch (i % 8)
                {
                    case 0:
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i+8]);
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i-7]);
                        possibleMoves.Add(BPs[i+9]);
                        break;
                    case 7:
                        possibleMoves.Add(BPs[i+8]);
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i-9]); //   -7, +1, +9]);
                        possibleMoves.Add(BPs[i-1]); //   -8,  0, +8]);
                        possibleMoves.Add(BPs[i+7]); //   -9, -1, +7
                        break;
                    default:
                        possibleMoves.Add(BPs[i-7]);
                        possibleMoves.Add(BPs[i+1]);
                        possibleMoves.Add(BPs[i+9]);
                        possibleMoves.Add(BPs[i-8]);
                        possibleMoves.Add(BPs[i+8]);
                        possibleMoves.Add(BPs[i-9]);
                        possibleMoves.Add(BPs[i-1]);
                        possibleMoves.Add(BPs[i+7]);
                        break;
                }
            }
        }
        else if(a == "BB" || a == "WB")
        {
            int j = i;
            j = i;
            while (j % 8 != 7 && j < 56)
            {
                j += 9;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0 && j < 56)
            {
                j += 7;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0 && j > 7)
            {
                j -= 9;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 7 && j > 7)
            {
                j -= 7;
                possibleMoves.Add(BPs[j]);
            }

        }
        else if(a.Contains("N"))
        {  
        }
        else if(a.Contains("R"))
        {
            int j = i;
            j = i;
            while (j % 8 != 7)
            {
                j += 1;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j > 7)
            {
                j -= 8;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0)
            {
                j -= 1;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j < 56)
            {
                j += 8;
                possibleMoves.Add(BPs[j]);
            }
        }else if(a.Contains("P")){ }
        else
        {
            int j = i;
            j = i;
            while (j % 8 != 7 && j < 56)
            {
                j += 9;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0 && j < 56)
            {
                j += 7;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0 && j > 7)
            {
                j -= 9;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 7 && j > 7)
            {
                j -= 7;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 7)
            {
                j += 1;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j > 7)
            {
                j -= 8;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j % 8 != 0)
            {
                j -= 1;
                possibleMoves.Add(BPs[j]);
            }
            j = i;
            while (j < 56)
            {
                j += 8;
                possibleMoves.Add(BPs[j]);
            }
        }
        foreach (Transform BP in possibleMoves)
        {
            BP.GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
    void OnMouseDrag() {
        gameObject.GetComponent<SpriteRenderer>().size = new Vector2(2.1f,2.1f);
        transform.position = new Vector3(
            Cam.ScreenToWorldPoint(Input.mousePosition).x,
            Cam.ScreenToWorldPoint(Input.mousePosition).y,
            -1.1f
        );
    }
    void OnMouseUp()
    {
        foreach (var BP in BPs)
        {
            switch (s[BPs.IndexOf(BP)])
                {
                    case 0:
                        BP.GetComponent<SpriteRenderer>().color = Color.grey;
                        break;
                    case 1:
                        BP.GetComponent<SpriteRenderer>().color = Color.white;
                        break;
                }
        }
        transform.position = GetClosest(BPs).position - new Vector3(0,0,1);
        gameObject.GetComponent<SpriteRenderer>().size = new Vector2(2,2);
    }
    Transform GetClosest(List<Transform> BP)
    {
        Transform T = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform tr in BP)
        {
            float dist = Vector3.Distance(tr.position, currentPos);
            if (dist < minDist)
            {
                T = tr;
                minDist = dist;
            }
        }
        return T;
    }
    GameObject[] GetEnemies(string n)
    {
        if (n.Contains("W"))
        {
            return GameObject.FindGameObjectsWithTag("Black");
        }else
        {
            return GameObject.FindGameObjectsWithTag("White");
        }
        
    }
}