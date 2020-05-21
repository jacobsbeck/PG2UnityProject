using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject blueWallKey;
    private DisplayBackground currentBackground;

    private void Start()
    {
        currentBackground = GameObject.Find("Background").GetComponent<DisplayBackground>();
        blueWallKey = GameObject.Find("key");
        blueWallKey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (blueWallKey != null)
        {
            if (currentBackground.CurrentWall == 2)
            {
                if (!blueWallKey.activeSelf)
                {
                    blueWallKey.SetActive(true);
                }
            }
            else
            {
                blueWallKey.SetActive(false);
            }
        }

    }
}
