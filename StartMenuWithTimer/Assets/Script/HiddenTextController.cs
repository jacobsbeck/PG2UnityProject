using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HiddenTextController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Text hidden;
    public InputField urlInput;
    public RectTransform windowOne;
    public RectTransform windowTwo;
    public RectTransform windowFin;
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

    public void OnPointerDown(PointerEventData data) 
    {
        if (gameObject.CompareTag("page1")) {
            windowOne.localScale = new Vector3(0f, 1f, 1f);
            windowTwo.localScale = new Vector3(1f, 1f, 1f);
            urlInput.text = "www.test2.com";
        } else if (gameObject.CompareTag("page2")) {
            windowTwo.localScale = new Vector3(0f, 1f, 1f);
            windowFin.localScale = new Vector3(1f, 1f, 1f);
            urlInput.text = "www.testFin.com";
        }
    }
}
