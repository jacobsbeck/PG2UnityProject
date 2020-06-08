using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sharingItemsScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        GameObject inventorysystem = GameObject.FindWithTag("Inventory");
        inventorysystem.GetComponent<InventorySystem>().current_click = -1;
        foreach (Transform child in GameObject.FindWithTag("Inventory").gameObject.transform)
        {
            child.GetComponent<Image>().color = Color.white;
        }
        gameObject.GetComponent<Image>().enabled = false;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
}
