using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    public Transform callContainer;
    public Text callText;
    private int callIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform call in callContainer)
        {
            call.GetComponent<Toggle>().onValueChanged.AddListener((on) =>
            {
                if (on)
                {
                    callCheck(call);
                    string[] callData = FileData.calls[callIndex].Split('/');
                    callText.text = "Caller: " + callData[0] + "\nDate: " + callData[1] + "\nReason: " + callData[2];
                }
            });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void callCheck(Transform call) {
        if (call.name == "Location1")
        {
            callIndex = 0;
        } 
        else if (call.name == "Location2") 
        {
            callIndex = 1;
        }
        else if (call.name == "Location3")
        {
            callIndex = 2;
        }
        else if (call.name == "Location4")
        {
            callIndex = 3;
        }
        else if (call.name == "Location5")
        {
            callIndex = 4;
        }
        else if (call.name == "Location6")
        {
            callIndex = 5;
        }
        else if (call.name == "Location7")
        {
            callIndex = 6;
        }
        else if (call.name == "Location8")
        {
            callIndex = 7;
        }
        else if (call.name == "Location9")
        {
            callIndex = 8;
        }
        else if (call.name == "Location10")
        {
            callIndex = 9;
        }
        else if (call.name == "Location11")
        {
            callIndex = 10;
        }
        else if (call.name == "Location12")
        {
            callIndex = 11;
        }
        else if (call.name == "Location13")
        {
            callIndex = 12;
        }
        else if (call.name == "Location14")
        {
            callIndex = 13;
        }
        else if (call.name == "Location15")
        {
            callIndex = 14;
        }
    }
}
