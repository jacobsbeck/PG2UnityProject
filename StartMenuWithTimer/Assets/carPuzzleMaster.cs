using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carPuzzleMaster : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] pictures;
    public static bool isWon;
    public GameObject final;
    public fuseMode fuseUV;
    public GameObject blueMode;
    public GameObject puzzleControl;
    int counterLock = 0;
    void Start()
    {
        isWon = false;
        final.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if( (pictures[1].rotation.z == 0 || pictures[1].rotation.z == 360) &&
            (pictures[2].rotation.z == 0 || pictures[2].rotation.z == 360) &&
            (pictures[3].rotation.z == 0 || pictures[3].rotation.z == 360) &&
            (pictures[4].rotation.z == 0 || pictures[4].rotation.z == 360) &&
            (pictures[5].rotation.z == 0 || pictures[5].rotation.z == 360) &&
            (pictures[6].rotation.z == 0 || pictures[6].rotation.z == 360) &&
            (pictures[7].rotation.z == 0 || pictures[7].rotation.z == 360) &&
            (pictures[8].rotation.z == 0 || pictures[8].rotation.z == 360) &&
            (pictures[9].rotation.z == 0 || pictures[9].rotation.z == 360) &&
            (pictures[10].rotation.z == 0 || pictures[10].rotation.z == 360) &&
            (pictures[11].rotation.z == 0 || pictures[11].rotation.z == 360) &&
            (pictures[12].rotation.z == 0 || pictures[12].rotation.z == 360) &&
            (pictures[13].rotation.z == 0 || pictures[13].rotation.z == 360) &&
            (pictures[14].rotation.z == 0 || pictures[14].rotation.z == 360) &&
            isWon == false)
        {
            Debug.Log("puzzleSolved");
            isWon = true;
            final.SetActive(true);
            puzzleControl.SetActive(false);
        }
        if (counterLock == 0 && fuseUV.isUV == true)
        {
            counterLock++;
            blueMode.SetActive(true);
            final.SetActive(false);
        }
    }

}
