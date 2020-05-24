using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject blueWall;
    private DisplayBackground currentBackground;

    private void Start()
    {
        currentBackground = GameObject.Find("Background").GetComponent<DisplayBackground>();
        blueWall = GameObject.FindWithTag("BlueWall");
        blueWall.SetActive(false);
        /*
        foreach (GameObject child in GameObject.FindWithTag("BlueWall").gameObject.transform)
        {
            child.SetActive(false);
        }
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (blueWall != null)
        {
            if (currentBackground.CurrentWall == 2)
            {
                if (!blueWall.activeSelf)
                {
                    blueWall.SetActive(true);
                    /*
                    foreach (GameObject child in GameObject.FindWithTag("BlueWall").gameObject.transform)
                    {
                        child.SetActive(false);
                    }
                    */
                }
            }
            else
            {
                blueWall.SetActive(false);
            }
        }

    }
}
