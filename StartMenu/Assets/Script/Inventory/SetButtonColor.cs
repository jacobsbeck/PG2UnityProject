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

    public void ResetColor()
    {
        foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
        {
            if (child != gameObject.transform) child.GetComponent<Image>().color = Color.white;
        }
    }
    public void changeColor()
    {
        //set all to white except the current object
        foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
        {
            if (child != gameObject.transform) child.GetComponent<Image>().color = Color.white;
        }
        Debug.Log("click");
        //change the click object state
        // if it is green, then white
        // else green
        //separate to check the state
        if(GetComponent<Image>().color == Color.green)
        {
            GetComponent<Image>().color = Color.white;
        }
        else GetComponent<Image>().color = Color.green;
        
        int count = -1;
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        //set the current to nothing click
        inventorysystem.GetComponent<InventorySystem>().current_click = -1;

        //find which button is click, change the current click item in inventory system
        foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
        {
            count++;
            //if it is the selected item
            if (child.GetComponent<Image>().color == Color.green) inventorysystem.GetComponent<InventorySystem>().current_click = count;
        }

    }
}
