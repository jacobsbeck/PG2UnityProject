using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DesktopBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool mouseOnDesktop = true;
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
        mouseOnDesktop = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        mouseOnDesktop = false;
    }
}
