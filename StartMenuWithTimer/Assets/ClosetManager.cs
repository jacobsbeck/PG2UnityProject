using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClosetManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject contentCloset;

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
    public int sceneCount;
    int Counter;
    void Start()
    {
        contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = suitClean;
        sceneCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //if (isEvent)
        ///{
            if (sceneCount == 3)
            {
                Debug.Log(sceneCount);
                if (fuseUV.isUV == true)
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = child2Blue;
                }
                else
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = child2;
                }
            }
            else if (sceneCount == 2)
            {
                if (fuseUV.isUV == true)
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = child1Blue;
                }
                else
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = child1;
                }
            }
            else if (sceneCount == 1)
            {
                if (fuseUV.isUV == true)
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = dressBlue;
                }
                else
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = dress;
                }
            }
            else if (sceneCount == 0)
            {
                if (fuseUV.isUV == true)
                {
                    Debug.Log("SuitBlueMode");
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = suitCleanBlue;
                }
                else
                {
                    contentCloset.gameObject.GetComponent<SpriteRenderer>().sprite = suitClean;
                }
            }
        //}
    }
}
