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
