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
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("PoliceScene");
    }

    public void timeLimitSelection()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("TimeLimitSelection");
    }

    public void noTimeLimit()
    {
        soundManager.PlaySound("clickUI");
        PlayerPrefs.SetFloat("Timer Active", 0);
        SceneManager.LoadScene("SampleScene");
    }

    public void tenMinutes()
    {
        soundManager.PlaySound("clickUI");
        PlayerPrefs.SetFloat("Timer Active", 1);
        SceneManager.LoadScene("SampleScene");
    }

    public void loadSample()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("SampleScene");
    }
    public void Tolocker()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("Locker");
    }

    public void policeIntroScenes()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("PoliceIntro");
    }

    public void VictimIntroNoTime()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("VictimIntroNoTime");
    }

    public void VictimIntroTime()
    {
        soundManager.PlaySound("clickUI");
        SceneManager.LoadScene("VictimIntroTime");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void Ending()
    {
        SceneManager.LoadScene("Ending");
    }
}
