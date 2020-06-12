using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fuseMode : MonoBehaviour
{
    public GameObject fuseboxClosedScene;
    public GameObject fuseboxOpenScene;
    public closedKeyDetect closedView;
    public BatteryDetect batteryView;
    public GameObject batterySolved;
    public GameObject UVScene;
    int count = 0;
    public Boolean isUV = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (closedView.isOpenKey == true && count == 0)
        {
            count = 1;
            StartCoroutine(waitToChange());
        }
        if (batteryView.isOpenBattery == true && count == 1)
        {
            count = 2;
            batterySolved.SetActive(true);
            StartCoroutine(waitToChange2());
            //change view
        }
    }

    //change scene
    IEnumerator waitToChange()
    {
        Debug.Log("ey");
        soundManager.PlaySound("fuseboxKey");
        yield return new WaitForSecondsRealtime(2);
        fuseboxClosedScene.SetActive(false);
        fuseboxOpenScene.SetActive(true);
    }

    IEnumerator waitToChange2()
    {
        Debug.Log("ey");
        soundManager.PlaySound("UVlight");
        yield return new WaitForSecondsRealtime(2);
        isUV = true;
        UVScene.SetActive(true);
        batterySolved.SetActive(false);
        fuseboxOpenScene.SetActive(false);
    }
}
