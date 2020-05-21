using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ApplicationController : MonoBehaviour, IPointerExitHandler
{
    public Button applicationToggle;
    public InputField searchInput;
    public Button[] applicationBtns;

    public GameObject windowPrefab;
    public GameObject filePrefab;
    public GameObject desktopArea;

    // Start is called before the first frame update
    void Start()
    {
        // In order to hide the ui element when not in use, we will have to either scale down the x or y to 0,
        // then in order to unhide we set the scales back to 1.
        transform.localScale = new Vector3(0, 1, 1);
        applicationToggle.onClick.AddListener(displayApplicationTab);
        for (int i = 0; i < applicationBtns.Length; i++) {
            if (applicationBtns[i].name.Equals("FileAppBtn"))
            {
                applicationBtns[i].onClick.AddListener(openDirectoryWindow);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void displayApplicationTab() 
    {
        if (transform.localScale.x == 1)
        {
            transform.localScale = new Vector3(0, 1, 1);
            searchInput.text = "";
        } else {
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void OnPointerExit(PointerEventData data)
    {
        transform.localScale = new Vector3(0, 1, 1);
        searchInput.text = "";
    }

    private void openDirectoryWindow() {
        GameObject newWindow = Instantiate(windowPrefab, desktopArea.transform);
        newWindow.transform.position = new Vector3(100, -100, 0) + newWindow.transform.position;
    }
}
