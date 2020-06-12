using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prototypeSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void switchToPuzzle()
    {
        SceneManager.LoadScene("OnlyPuzzles");

    }
    public void switchToGameItems()
    {
        SceneManager.LoadScene("OnlyGameItems");

    }
    public void switchToGameScenes()
    {
        SceneManager.LoadScene("OnlyGameScenes");

    }
    public void switchToNarrative()
    {
        SceneManager.LoadScene("OnlyNarrative");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("PrototypeMenu");
    }

}
