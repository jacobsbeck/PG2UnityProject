using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehavour : MonoBehaviour
{
    public Transform border;
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
        Debug.Log("click");
        //m_Renderer = GetComponent<Renderer>();
        //m_Renderer.material.color = Color.green;
    }
}
