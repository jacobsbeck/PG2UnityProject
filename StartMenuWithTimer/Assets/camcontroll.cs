using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontroll : MonoBehaviour
{
    public Camera cam;
    public GameObject main;
    public GameObject newUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backToMain()
    {
        cam.transform.position = new Vector3(-0.02f ,0,-10);
        main.SetActive(true);
        newUI.SetActive(false);
    }
}
