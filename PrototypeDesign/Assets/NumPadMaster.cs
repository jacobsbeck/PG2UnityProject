using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumPadMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public int buttonClicked;
    public Text displayBar;
    public string inputString;
    public bool isInput = false;
    public int clickerCounter; //8-1

    public int[] numInput;

    void Start()
    {
        displayBar.text = "EMPTY";
        numInput = new int[8];

    }

    // Update is called once per frame
    void Update()
    {
        if (isInput)
        {
            EnqueueInput();
            isInput = false;
        }
    }
    void EnqueueInput()
    {
        if (buttonClicked == 10 && clickerCounter <= 7)
        {
            Debug.Log("displaying");
            displayInput();
        }
        else if (buttonClicked == -1 || clickerCounter > 7)
        {
            Debug.Log("cleared");
            inputString = " ";
            clickerCounter = 0;
        }
        else if(clickerCounter <= 7)
        {
            Debug.Log("added");
            numInput[clickerCounter] = buttonClicked;
        }
        buttonClicked = 0;
    }

    void displayInput()
    {
        Debug.Log("displaying1");
        buttonClicked = 0;
        for (int i = 1; i <= numInput.Length - 1; i++)
        {
            Debug.Log("displaying2");
            Debug.Log(numInput[i]);
            inputString = inputString + numInput[i].ToString();
        }
        displayBar.text = inputString;
        inputString = null;
        clickerCounter = 0;
    }
}
