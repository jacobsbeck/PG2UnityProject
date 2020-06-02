using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CypherView : MonoBehaviour
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
        cam.transform.position = new Vector3(19.54f, 0, -10);
        canvas.SetActive(false);
        newUI.SetActive(true);
    }
}
