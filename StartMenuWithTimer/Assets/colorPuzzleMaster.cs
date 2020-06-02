using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorPuzzleMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public int buttonClicked;
    public Text displayBar;
    public string inputString;
    public bool isInput = false;
    public int clickerCounter; //8-1
    public bool isOpen = false;
    public GameObject closedGrate;
    public GameObject openGrate;

    public int[] numInput;

    void Start()
    {
        numInput = new int[5];

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
    Debug.Log("added");
    Debug.Log("clickerCounter");
    numInput[clickerCounter] = buttonClicked;
    if (clickerCounter == 4)
    {
        Debug.Log("displaying");
        displayInput();
    }
        buttonClicked = 0;//reset button press
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
        if (inputString.Equals("3432"))
        {
            soundManager.PlaySound("SafeboxRight");
            Debug.Log("goodJob");
            isOpen = true;
            openGrate.SetActive(true);
            closedGrate.SetActive(false);
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
