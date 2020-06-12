using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public NumPadMaster numpadmaster;
    public int myNumber;

    // Start is called before the first frame update
    public void OnMouseDown()
    {
        Debug.Log(myNumber);
        numpadmaster.buttonClicked = myNumber;
        numpadmaster.clickerCounter++;
        numpadmaster.isInput = true;
    }
}
