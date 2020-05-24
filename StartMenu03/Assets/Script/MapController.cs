using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapController : MonoBehaviour
{
    public Transform callContainer;
    public Text callText;
    private int callIndex = 0;
    private string[] callInfo = {
        "Jimmy James/1:45 AM/Arson",
        "Katie Kall/10:37 AM/Missing Person",
        "Tom Tele/2:53 PM/Missing Person",
        "Abbie Apple/3:19 AM/Home Invasion"
    };
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
                    string[] callData = callInfo[callIndex].Split('/');
                    callText.text = "Caller - " + callData[0] + "\nTime - " + callData[1] + "\nReason - " + callData[2];
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
    }
}
