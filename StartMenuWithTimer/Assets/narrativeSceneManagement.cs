using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class narrativeSceneManagement : MonoBehaviour
{
    public GameObject narrativeEvent;
    public GameObject narrativeDesign;
    private bool isEvent = false;
    private bool isDesign = false;
    // Start is called before the first frame update
    public void switchDesign()
    {
        Debug.Log("Pee");
        isEvent = false;
        isDesign = true;
        setNarrativeScene();
    }

    public void MainMenu()
    {
        Debug.Log("Pee");
        isEvent = false;
        isDesign = false;
        setNarrativeScene();
        SceneManager.LoadScene("PrototypeMenu");
    }

    public void switchEvent()
    {
        Debug.Log("Pee");
        isEvent = true;
        isDesign = false;
        setNarrativeScene();
    }

    private void setNarrativeScene()
    {
        narrativeEvent.SetActive(isEvent);
        narrativeDesign.SetActive(isDesign);
    }
}
