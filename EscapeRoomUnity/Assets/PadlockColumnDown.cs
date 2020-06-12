using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PadlockColumnDown : MonoBehaviour
{
    public padLockColumnUp padLockUp;

    //Ooga booga Caveman brain implementation for now. 
    string[] capAlph = new string[] { "A", "B", "C", "D", "E", "F", "G", "H",
        "I","J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
        "U", "V", "W", "X", "Y", "Z"};

    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnMouseDown()
    {
        Debug.Log("down");
        if (padLockUp.clickerCounter == 0)
        {
            padLockUp.clickerCounter = 3;
            padLockUp.currentLetter = padLockUp.startLetter + (padLockUp.letterMultiplier * 3);
            padLockUp.Column.text = capAlph[padLockUp.currentLetter];
        }
        else
        {
            padLockUp.clickerCounter--;
            padLockUp.currentLetter -= padLockUp.letterMultiplier;
            if (padLockUp.currentLetter < 0)
            {
                    padLockUp.currentLetter += 26;
            }
            padLockUp.Column.text = capAlph[padLockUp.currentLetter];
        }
        Debug.Log(padLockUp.currentLetter);
        soundManager.PlaySound("changeLetters");
    }
}
