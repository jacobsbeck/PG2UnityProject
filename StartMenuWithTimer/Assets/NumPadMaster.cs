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
    public bool isOpen = false;
    public GameObject safePuzzle;

    public int[] numInput;

    void Start()
    {
        displayBar.text = "EMPTY";
        numInput = new int[9]; //+1 of intended size (if 4 then 5)

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
        if (buttonClicked == 10 && clickerCounter <= 9)
        {
            Debug.Log("displaying");
            displayInput();
        }
        else if (buttonClicked == -1 || clickerCounter > 8)
        {
            if (clickerCounter > 8)
            {
                Debug.Log("toomany");
                soundManager.PlaySound("safeWrong");
            }
            else 
            {
                soundManager.PlaySound("safeClear");
            }
            Debug.Log("cleared");
            for (int i = 1; i <= numInput.Length - 1; i++)
            {
                Debug.Log(numInput[i]);
                inputString = inputString + numInput[i].ToString();
            }
            Debug.Log(inputString);
            inputString = "";
            clickerCounter = 0;
            for (int i = 0; i <= numInput.Length - 1; i++)
            {
                numInput[i] = 0;
            }
        }
        else if (buttonClicked == -2)//??
        {
            Debug.Log("Exit Clear");
            for (int i = 1; i <= numInput.Length - 1; i++)
            {
                Debug.Log(numInput[i]);
                inputString = inputString + numInput[i].ToString();
            }
            Debug.Log(inputString);
            inputString = "";
            clickerCounter = 0;
            for (int i = 0; i <= numInput.Length - 1; i++)
            {
                numInput[i] = 0;
            }
        }
        else if(clickerCounter <= 8)//??
        {
            Debug.Log("added");
            soundManager.PlaySound("safeKeypad");
            numInput[clickerCounter] = buttonClicked;
        }
        buttonClicked = 0;
    }

    void displayInput()
    {
        buttonClicked = 0;
        for (int i = 1; i <= numInput.Length - 1; i++)
        {
            Debug.Log(numInput[i]);
            inputString = inputString + numInput[i].ToString();
        }
        Debug.Log(inputString);
        displayBar.text = inputString;
        if (inputString.Equals("47610002"))
        {
            Debug.Log("goodJob");
            isOpen = true;
            safePuzzle.SetActive(false);
        }
        else
        {
            soundManager.PlaySound("safeWrong");
        }
        inputString = "";
        for (int i = 0; i <= numInput.Length - 1; i++)
        {
            numInput[i] = 0;
        }
        clickerCounter = 0;
    }
}
