using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetManager : MonoBehaviour
{
    // Start is called before the first frame update

    public Sprite suitBattery;
    public Sprite suitClean;
    public Sprite dress;
    public Sprite child1;
    public Sprite child2;

    public fuseMode fuseUV;
    public Sprite suitCleanBlue;
    public Sprite dressBlue;
    public Sprite child1Blue;
    public Sprite child2Blue;



    public forwardCloset forwardCount;
    public backwardCloset backwardCount;
    public batteryPicked batteryItem;
    public int sceneCount = 0;
    public bool isEvent = false;
    int Counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEvent)
        {
            if (sceneCount == 3)
            {
                if (fuseUV.isUV == true)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = child2Blue;
                }
                else
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = child2;
                }
            }
            else if (sceneCount == 2)
            {
                if (fuseUV.isUV == true)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = child1Blue;
                }
                else
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = child1;
                }
            }
            else if (sceneCount == 1)
            {
                if (fuseUV.isUV == true)
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = dressBlue;
                }
                else
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = dress;
                }
            }
            else if (sceneCount == 0)
            {
                if (fuseUV.isUV == true)
                {
                    Debug.Log("SuitBlueMode");
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = suitCleanBlue;
                }
                else
                {
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = suitClean;
                }
            }
        }
    }
}
