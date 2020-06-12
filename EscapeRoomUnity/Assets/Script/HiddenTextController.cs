using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HiddenTextController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Text hidden;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData data)
    {
        Color col = hidden.GetComponent<Text>().color;
        col.a = 255;
        hidden.GetComponent<Text>().color = col;
    }

    public void OnPointerExit(PointerEventData data)
    {
        Color col = hidden.GetComponent<Text>().color;
        col.a = 0;
        hidden.GetComponent<Text>().color = col;
    }
}
