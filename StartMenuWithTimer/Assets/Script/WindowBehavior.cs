using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class WindowBehavior : MonoBehaviour
{
    public UnityEngine.UI.Button closeBtn;
    public UnityEngine.UI.Button minimizeBtn;
    public GameObject desktopArea;
    public RectTransform windowBar;

    public GameObject[] files;
    public GameObject[] folder;
    private bool pointerCanMove = false;
    private float xOffset = 0f;
    private float yOffset = 0f;
    // Start is called before the first frame update
    void Start()
    {
        closeBtn.onClick.AddListener(closeWindow);
        minimizeBtn.onClick.AddListener(closeWindow);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 localMousePosition = windowBar.InverseTransformPoint(Input.mousePosition);
        if (windowBar.rect.Contains(localMousePosition) && Input.GetMouseButtonDown(0))
        {
            xOffset = Vector2.Distance(new Vector2(Input.mousePosition.x, 0), new Vector2(transform.position.x, 0));
            yOffset = Vector2.Distance(new Vector2(0, Input.mousePosition.y), new Vector2(0, transform.position.y));
        }
        if (windowBar.rect.Contains(localMousePosition) && Input.GetMouseButton(0))
        {
            transform.position = new Vector2(Input.mousePosition.x - xOffset, Input.mousePosition.y + yOffset);
        }

        if (Input.GetMouseButtonDown(0) && pointerCanMove)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    private void canMoveWindow() {
        Debug.Log("entered");
        pointerCanMove = true;
    }

    private void canNotMoveWindow()
    {
        Debug.Log("exited");
        pointerCanMove = false;
    }

    private void closeWindow() {
        transform.localScale = new Vector3(0, 1, 1);
        transform.localPosition = new Vector3(0, 0, 0);
    }

    private void minimizeWindow() {
        transform.localScale = new Vector3(0, 1, 1);
    }

    private bool IsPointInRT(Vector3 mousePos, RectTransform rt)
    {

        Vector2 point = mousePos - new Vector3(Screen.width / 2, Screen.height / 2);
        // Get the rectangular bounding box of your UI element
        Rect rect = rt.rect;

        // Get the left, right, top, and bottom boundaries of the rect
        float leftSide = rt.anchoredPosition.x - rect.width / 2;
        float rightSide = rt.anchoredPosition.x + rect.width / 2;
        float topSide = rt.anchoredPosition.y + rect.height / 2;
        float bottomSide = rt.anchoredPosition.y - rect.height / 2;

        //Debug.Log(leftSide + ", " + rightSide + ", " + topSide + ", " + bottomSide);

        // Check to see if the point is in the calculated bounds
        if (point.x >= leftSide &&
            point.x <= rightSide &&
            point.y >= bottomSide &&
            point.y <= topSide)
        {
            return true;
        }
        return false;
    }
}
