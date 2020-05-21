using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayBackground : MonoBehaviour
{
    public int CurrentWall
    {
        get { return currentWall; }
        set {
            if (value == 0) {
                currentWall = 4;
            }else if (value == 5)
            {
                currentWall = 1;
            }
            else
                currentWall = value;
        }
    }

    private int currentWall;
    private int previousWall;

    private void Start()
    {
        currentWall = 1;
        previousWall = 1;
    }

    void Update()
    {
        if (currentWall != previousWall)
        {
            Debug.Log("currentWall" + currentWall);
            Debug.Log("previousWall" + previousWall);
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Room" + currentWall.ToString());
        }
        previousWall = currentWall;
    }
}
