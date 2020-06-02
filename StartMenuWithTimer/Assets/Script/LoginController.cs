using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginController : MonoBehaviour
{
    public Button loginBtn;
    public RectTransform puzzleHolder;
    // Start is called before the first frame update
    void Start()
    {
        loginBtn.onClick.AddListener(closeLogin);
    }

    // Update is called once per frame
    void Update()
    {
        int numCorrect = 0;
        foreach (Transform child in puzzleHolder) {
            //Debug.Log(child.eulerAngles.z);
            if (child.eulerAngles == Vector3.zero) {
                numCorrect++;
            }
        }

        if (numCorrect >= 50) {
            loginBtn.interactable = true;
        }
    }

    private void closeLogin() {
        transform.localScale = new Vector3(0, 1, 1);
    }
}
