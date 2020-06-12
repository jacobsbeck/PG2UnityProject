using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static AudioClip changeLetters, clickUI, fuseboxKey, SafeboxRight, safeKeypad, safeWrong, unlockCypher, UVlight, safeClear, soundtrack1, endAlpha, gameOver;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        changeLetters = Resources.Load<AudioClip>("changeLetters");
        clickUI = Resources.Load<AudioClip>("clickUI");
        fuseboxKey = Resources.Load<AudioClip>("fuseboxKey");
        SafeboxRight = Resources.Load<AudioClip>("SafeboxRight");
        safeKeypad = Resources.Load<AudioClip>("safeKeypad");
        safeWrong = Resources.Load<AudioClip>("safeWrong");
        unlockCypher = Resources.Load<AudioClip>("unlockCypher");
        UVlight = Resources.Load<AudioClip>("UVlight");
        safeClear = Resources.Load<AudioClip>("safeClear");
        soundtrack1 = Resources.Load<AudioClip>("soundtrack1");
        endAlpha = Resources.Load<AudioClip>("endAlpha");
        gameOver = Resources.Load<AudioClip>("gameOver");

        audioSrc = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "changeLetters":
                audioSrc.PlayOneShot(changeLetters);
                break;
            case "clickUI":
                audioSrc.PlayOneShot(clickUI);
                break;
            case "fuseboxKey":
                audioSrc.PlayOneShot(fuseboxKey);
                break;
            case "SafeboxRight":
                audioSrc.PlayOneShot(SafeboxRight);
                break;
            case "safeKeypad":
                audioSrc.PlayOneShot(safeKeypad);
                break;
            case "safeWrong":
                audioSrc.PlayOneShot(safeWrong);
                break;
            case "unlockCypher":
                audioSrc.PlayOneShot(unlockCypher);
                break;
            case "UVlight":
                audioSrc.PlayOneShot(UVlight);
                break;
            case "safeClear":
                audioSrc.PlayOneShot(safeClear);
                break;
            case "soundtrack1":
                audioSrc.PlayOneShot(soundtrack1);
                break;
            case "endAlpha":
                audioSrc.PlayOneShot(endAlpha);
                break;
            case "gameOver":
                audioSrc.PlayOneShot(gameOver);
                break;

        }
    }
}
