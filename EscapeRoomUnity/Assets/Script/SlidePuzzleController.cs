using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlidePuzzleController : MonoBehaviour, IPointerDownHandler
{
    private bool selected = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData data)
    {
        if (selected) {
            selected = false;
            transform.GetComponent<Image>().color = Color.white;
        } else {
            selected = true;
            transform.GetComponent<Image>().color = Color.black;
        }
    }
}
