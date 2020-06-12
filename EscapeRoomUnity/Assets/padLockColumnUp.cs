using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class padLockColumnUp : MonoBehaviour
{
    //public Text Column;
    public int clickerCounter = 4;
    public int startLetter = 0;
    public int letterMultiplier = 0;
    public int currentLetter = 0;
    public TextMeshProUGUI Column;

    //Ooga booga Caveman brain implementation for now. 
    string[] capAlph = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", 
        "I","J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", 
        "U", "V", "W", "X", "Y", "Z"};
    //first col,mult+3: I(8),L(11),O(14), R(17)
    //second col, Mult+2: S(18),U(20),W(22),Y(24) 
    //third col, mult-3: J(9),G(6),D(3),A(0)
    //fourth col, mult+3: I(8),L(11),O(14), R(17)
    //fifth col, mult-3: J(9),G(6),D(3),A(0)

    //alt fourth col, mult+3: E(4),H(7),K(10),N(13)


    // Start is called before the first frame update
    void Start()
    {
        currentLetter = startLetter;
        Column.text = capAlph[startLetter];
    }

    public void OnMouseDown()
    {
        Debug.Log("up");
        if (clickerCounter == 3)
        {
            clickerCounter = 0;
            currentLetter = startLetter;
            Column.text = capAlph[startLetter];
        }
        else
        {
            clickerCounter++;
            currentLetter += letterMultiplier;
            if (currentLetter > 25)
            {
                currentLetter -= 26;
            }
            Column.text = capAlph[currentLetter];
        }
        Debug.Log(currentLetter);
        soundManager.PlaySound("changeLetters");
    }
}
