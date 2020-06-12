using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public CombinationPuzzleManagerDrawer puzzleSolved;
    public GameObject puzzleController;
    public GameObject puzzle;
    public GameObject closet;
    public GameObject lockCloset;
    private int changeScene = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleSolved.closetOpened == true && changeScene == 0)
        {
            Debug.Log("hey");
            //soundManager.PlaySound("unlockCypher");
            puzzle.SetActive(false);
            closet.SetActive(true);
            lockCloset.SetActive(false);
            puzzleController.SetActive(false);
            changeScene++;
        }

    }
}
