using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject blueWall;
    public GameObject Room1;
    public GameObject Room4;
    public GameObject Room3;
    private DisplayBackground currentBackground;

    private void Start()
    {
        currentBackground = GameObject.Find("Background").GetComponent<DisplayBackground>();
        blueWall = GameObject.FindWithTag("BlueWall");
        blueWall.SetActive(false);
        Room1.SetActive(false);
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
                    Room1.SetActive(false);
                    Room4.SetActive(false);
                    Room3.SetActive(false);
                    /*
                    foreach (GameObject child in GameObject.FindWithTag("BlueWall").gameObject.transform)
                    {
                        child.SetActive(false);
                    }
                    */
                }
            }
            else if (currentBackground.CurrentWall == 1)
            {
                if (!Room1.activeSelf)
                {
                    blueWall.SetActive(false);
                    Room1.SetActive(true);
                    Room4.SetActive(false);
                    Room3.SetActive(false);
                    /*
                    foreach (GameObject child in GameObject.FindWithTag("BlueWall").gameObject.transform)
                    {
                        child.SetActive(false);
                    }
                    */
                }
            }
            else if (currentBackground.CurrentWall == 4)
            {
                if (!Room4.activeSelf)
                {
                    blueWall.SetActive(false);
                    Room1.SetActive(false);
                    Room4.SetActive(true);
                    Room3.SetActive(false);
                    /*
                    foreach (GameObject child in GameObject.FindWithTag("BlueWall").gameObject.transform)
                    {
                        child.SetActive(false);
                    }
                    */
                }
            }
            else if (currentBackground.CurrentWall == 3)
            {
                if (!Room3.activeSelf)
                {
                    blueWall.SetActive(false);
                    Room1.SetActive(false);
                    Room4.SetActive(false);
                    Room3.SetActive(true);
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
                Room1.SetActive(false);
                Room4.SetActive(false);
            }
        }

    }
}
