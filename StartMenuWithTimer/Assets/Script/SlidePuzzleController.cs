using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SlidePuzzleController : MonoBehaviour, IPointerDownHandler
{
    public RectTransform open;
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
        if (Vector2.Distance(transform.localPosition, open.localPosition) == 100)
        {
            float tempX = transform.localPosition.x;
            float tempY = transform.localPosition.y;
            transform.localPosition = open.localPosition;
            open.localPosition = new Vector2(tempX, tempY);
        }
    }
}
