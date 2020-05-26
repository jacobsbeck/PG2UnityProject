using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class paintView : MonoBehaviour
{
    public Camera cam;
    public GameObject canvas;
    public GameObject newUI;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        cam.transform.position = new Vector3(0.6f, -17, -10);
        canvas.SetActive(true);
        newUI.SetActive(true);
    }
}
