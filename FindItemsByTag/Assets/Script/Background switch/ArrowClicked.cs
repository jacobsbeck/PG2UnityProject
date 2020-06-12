using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowClicked : MonoBehaviour
{

    private DisplayBackground currentBackground;

    private void Start() {
        currentBackground = GameObject.Find("Background").GetComponent<DisplayBackground>();
    }

    public void OnRightClick()
    {
        currentBackground.CurrentWall = currentBackground.CurrentWall + 1;
    }
    public void OnLeftClick()
    {
        currentBackground.CurrentWall = currentBackground.CurrentWall - 1;
    }

    public void OnUVClick()
    {
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
