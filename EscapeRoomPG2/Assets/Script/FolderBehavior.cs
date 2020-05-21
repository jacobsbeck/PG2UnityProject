using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FolderBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool pointerOnFolder = false;
    public GameObject desktopArea;
    public GameObject folderWindow;
    private bool windowOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        folderWindow.transform.localScale = new Vector3(0, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && pointerOnFolder)
        {
            folderWindow.transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetMouseButton(1) && pointerOnFolder)
        {
            if (!rectOverlaps(gameObject.GetComponent<RectTransform>(), desktopArea.GetComponent<RectTransform>()))
            {
                transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
            else
            {
                Color col = transform.GetComponent<Image>().color;
                col.a = 0;
                transform.GetComponent<Image>().color = col;
                pointerOnFolder = false;
            }
        }
    }

    private bool rectOverlaps(RectTransform rectTrans1, RectTransform rectTrans2)
    {
        Rect rect1 = new Rect(rectTrans1.localPosition.x, rectTrans1.localPosition.y, rectTrans1.rect.width, rectTrans1.rect.height);
        Rect rect2 = new Rect(rectTrans2.localPosition.x, rectTrans2.localPosition.y, rectTrans2.rect.width, rectTrans2.rect.height);

        return rect1.Overlaps(rect2);
    }

    public void OnPointerEnter(PointerEventData data) {
        Color col = transform.GetComponent<Image>().color;
        col.a = 80f / 255f;
        transform.GetComponent<Image>().color = col;
        pointerOnFolder = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        Color col = transform.GetComponent<Image>().color;
        col.a = 0;
        transform.GetComponent<Image>().color = col;
        pointerOnFolder = false;
    }
}
