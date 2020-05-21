using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class FileBehavior : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Text nameTxt;
    private Text dateTxt;
    private Text typeTxt;
    private bool pointerOnFile = false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++) {
            if (transform.GetChild(i).name.Equals("fileName")) {
                nameTxt = transform.GetChild(i).GetComponent<Text>();
            } else if (transform.GetChild(i).name.Equals("fileDate")) {
                dateTxt = transform.GetChild(i).GetComponent<Text>();
            } else if (transform.GetChild(i).name.Equals("fileType")) {
                typeTxt = transform.GetChild(i).GetComponent<Text>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData data)
    {
        Color col = transform.GetComponent<Image>().color;
        col.a = 150f / 255f;
        transform.GetComponent<Image>().color = col;
        pointerOnFile = true;
    }

    public void OnPointerExit(PointerEventData data)
    {
        Color col = transform.GetComponent<Image>().color;
        col.a = 100f / 255f;
        transform.GetComponent<Image>().color = col;
        pointerOnFile = false;
    }
}
