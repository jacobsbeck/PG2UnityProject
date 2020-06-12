using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorPressed : MonoBehaviour
{
    public colorPuzzleMaster colorPuzzleMaster;
    public int myNumber;

    // Start is called before the first frame update
    public void OnMouseDown()
    {
        soundManager.PlaySound("safeKeypad");
        Debug.Log(myNumber);
        colorPuzzleMaster.buttonClicked = myNumber;
        colorPuzzleMaster.clickerCounter++;
        colorPuzzleMaster.isInput = true;
    }
}
