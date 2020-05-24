using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void policeScenes()
    {
        SceneManager.LoadScene("PoliceScene");
    }

    public void timeLimitSelection()
    {
        SceneManager.LoadScene("TimeLimitSelection");
    }

    public void noTimeLimit()
    {
        PlayerPrefs.SetFloat("Timer Active", 0);
        SceneManager.LoadScene("SampleScene");
    }

    public void tenMinutes()
    {
        PlayerPrefs.SetFloat("Timer Active", 1);
        SceneManager.LoadScene("SampleScene");
    }
}
