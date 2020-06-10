using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hintText;
    bool hintStatus;
    void Start()
    {
        hintStatus = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        hintStatus = !hintStatus;
        hintText.SetActive(hintStatus);
    }

    private void OnMouseExit()
    {
        hintStatus = !hintStatus;
        hintText.SetActive(hintStatus);
    }
}
