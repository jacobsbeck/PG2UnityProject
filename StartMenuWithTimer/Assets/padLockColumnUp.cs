using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class padLockColumnUp : MonoBehaviour
{
    public Text Column;
    public int clickerCounter = 0;

    //Ooga booga Caveman brain implementation for now. 
    string[] capAlph = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", 
        "I","J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", 
        "U", "V", "W", "X", "Y", "Z"};

    // Start is called before the first frame update
    void Start()
    {
        Column.text = capAlph[clickerCounter];
    }

    public void OnMouseDown()
    {
        Debug.Log("up");
        if (clickerCounter == 25)
        {
            clickerCounter = 0;
        }
        else
        {
            clickerCounter++;
        }
        Debug.Log(clickerCounter);
        Column.text = capAlph[clickerCounter];
    }
}
