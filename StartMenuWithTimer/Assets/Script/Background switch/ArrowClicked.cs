using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClicked : MonoBehaviour
{

    private DisplayBackground currentBackground;
    public fuseMode fusebox;
    private int lightLock = 0;
    public GameObject blueController;
    public bool powerOn = false;

    private void Start() {
        currentBackground = GameObject.Find("Background").GetComponent<DisplayBackground>();
    }

    private void Update()
    {
        if (fusebox.isUV == true && lightLock == 0)
        {
            if (powerOn == false)
            {
                powerOn = true;
                blueController.SetActive(true);
            }
            lightLock++;
            currentBackground.UVFilter = !currentBackground.UVFilter;
            if (currentBackground.UVFilter == false)
            {
                currentBackground.RefreshFilterNormal();
            }
            else
            {
                currentBackground.RefreshFilterRed();
            }
        }
    }

    public void OnRightClick()
    {
        soundManager.PlaySound("clickUI");
        currentBackground.CurrentWall = currentBackground.CurrentWall + 1;
    }
    public void OnLeftClick()
    {
        soundManager.PlaySound("clickUI");
        currentBackground.CurrentWall = currentBackground.CurrentWall - 1;
    }

    public void OnUVClick()
    {
        fusebox.isUV = !fusebox.isUV;
        currentBackground.UVFilter = !currentBackground.UVFilter;
        if (currentBackground.UVFilter == false)
        {
            currentBackground.RefreshFilterNormal();
        }
        else
        {
            currentBackground.RefreshFilterRed();
        }
    }
}
