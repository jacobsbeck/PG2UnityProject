﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missingPieceDetect : MonoBehaviour
{
    public bool isOpenKey;
    public GameObject finalTile;
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
        Debug.Log(inventorysystem.GetComponent<InventorySystem>().currentitem());
        if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "tileKey")
        {
            Debug.Log("KEY DETECTED"); //if (inventorysystem.GetComponent<InventorySystem>().currentitem() == "Key-PNG-Clipart-Background")
            finalTile.SetActive(true);
        }
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //   if (col.tag == "fuseKey")
    //    {
    //        isOpenKey = true;
    //    }
    // }
}
