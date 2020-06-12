using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameItemSceneManager : MonoBehaviour
{
    public void MainMenu()
    {
        Debug.Log("Pee");
        SceneManager.LoadScene("PrototypeMenu");
    }

}
