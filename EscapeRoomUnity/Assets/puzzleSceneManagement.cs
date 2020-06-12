using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleSceneManagement : MonoBehaviour
{
    public GameObject padlock;
    public GameObject safe;
    public GameObject fusebox;
    private bool isPadlock = false;
    private bool isfuseBox = false;
    private bool isSafe = false;
    // Start is called before the first frame update
    public void switchPadlock()
    {
        Debug.Log("Pee");
        isPadlock = true;
        isfuseBox = false;
        isSafe = false;
        setScene();
    }

    public void switchSafe()
    {
        Debug.Log("See");
        isPadlock = false;
        isfuseBox = false;
        isSafe = true;
        setScene();
    }

    public void switchFusebox()
    {
        Debug.Log("Fee");
        isPadlock = false;
        isfuseBox = true;
        isSafe = false;
        setScene();
    }

    private void setScene()
    {
        padlock.SetActive(isPadlock);
        fusebox.SetActive(isfuseBox);
        safe.SetActive(isSafe);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("PrototypeMenu");
    }

}
