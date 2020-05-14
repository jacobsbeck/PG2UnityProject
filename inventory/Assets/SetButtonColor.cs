using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButtonColor : MonoBehaviour
{
    Renderer m_Renderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeColor()
    {
        foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
        {
            if (child != gameObject.transform) child.GetComponent<Image>().color = Color.white;
        }
        Debug.Log("click");
        if(GetComponent<Image>().color == Color.green)
        {
            GetComponent<Image>().color = Color.white;
        }
        else GetComponent<Image>().color = Color.green;

    }
}
