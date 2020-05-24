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

    public bool UVFilter
    {
        get { return uvfilter; }
        set
        {
            uvfilter = value;
        }
    }

    private int currentWall;
    private int previousWall;
    private bool uvfilter;

    private void Start()
    {
        currentWall = 1;
        previousWall = 1;
        uvfilter = false;
    }

    void Update()
    {
        if (currentWall != previousWall && uvfilter == false)
        {
            Debug.Log("currentWall" + currentWall);
            Debug.Log("previousWall" + previousWall);
            RefreshFilterNormal();
        } else if (currentWall != previousWall && uvfilter == true)
        {
            RefreshFilterRed();
        }
        previousWall = currentWall;
    }

    public void RefreshFilterNormal()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Room" + currentWall.ToString());
    }
    public void RefreshFilterRed()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/RedRoom" + currentWall.ToString());
    }
}
