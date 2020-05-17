using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UVMode : MonoBehaviour
{
    public GameObject North;
    public GameObject South;
    public GameObject Left;
    public GameObject Right;

    private bool isUVMode = false;
    
    public void SetUVMode()
    {
        isUVMode = !isUVMode;
        if (isUVMode)
        {
            North.SetActive(true);
            South.SetActive(true);
            Left.SetActive(true);
            Right.SetActive(true);
        }
        else 
        {
            North.SetActive(false);
            South.SetActive(false);
            Left.SetActive(false);
            Right.SetActive(false);
        }

    }

    public void MainMenu()
    {
        Debug.Log("Pee");
        North.SetActive(false);
        South.SetActive(false);
        Left.SetActive(false);
        Right.SetActive(false);
        SceneManager.LoadScene("PrototypeMenu");
    }
}
