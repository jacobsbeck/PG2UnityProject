using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public UnityEngine.UI.Button searchBtn;
    public UnityEngine.UI.Button mapBtn;

    public UnityEngine.UI.Button loadUrlBtn;
    public UnityEngine.UI.Button refreshUrlBtn;

    public RectTransform searchWindow;
    public RectTransform mapWindow;
    public RectTransform noPageWindow;
    public RectTransform puzzleWindow;
    public RectTransform puzzleWindow1;
    public RectTransform puzzleWindow2;
    public RectTransform puzzleWindow3;

    public InputField urlText;
    private int currentTab = 0;
    private bool noPageShowing = false;
    private bool puzzlePageShowing = false;

    // Start is called before the first frame update
    void Start()
    {
        searchBtn.onClick.AddListener(loadSearchTab);
        mapBtn.onClick.AddListener(loadMapTab);
        loadUrlBtn.onClick.AddListener(loadUrl);
        refreshUrlBtn.onClick.AddListener(refreshUrl);

        urlText.text = "www.search.com";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            loadUrl();
        }
    }

    private void loadSearchTab() 
    {
        clearCurrentWindow();
        currentTab = 0;
        searchWindow.localScale = new Vector3(1, 1, 1);
        Color col = searchBtn.GetComponent<Image>().color;
        col.a = 1;
        searchBtn.GetComponent<Image>().color = col;
        urlText.text = "www.search.com";
    }

    private void loadMapTab()
    {
        clearCurrentWindow();
        currentTab = 1;
        mapWindow.localScale = new Vector3(1, 1, 1);
        Color col = mapBtn.GetComponent<Image>().color;
        col.a = 1;
        mapBtn.GetComponent<Image>().color = col;
        urlText.text = "www.map.com";
    }

    private void loadUrl() {
        string t = urlText.text.Replace("www.", "");
        clearCurrentWindow();
        if (t == "test.com")
        {
            puzzleWindow.localScale = new Vector3(1, 1, 1);
            puzzlePageShowing = true;
        }
        else if (t == "search.com")
        {
            loadSearchTab();
        }
        else if (t == "map.com")
        {
            loadMapTab();
        }
        else if (t == "test1.com")
        {
            puzzleWindow1.localScale = new Vector3(1, 1, 1);
            puzzlePageShowing = true;
        }
        else if (t == "test2.com")
        {
            puzzleWindow2.localScale = new Vector3(1, 1, 1);
            puzzlePageShowing = true;
        }
        else if (t == "test3.com")
        {
            puzzleWindow3.localScale = new Vector3(1, 1, 1);
            puzzlePageShowing = true;
        }
        else if (t != "map.com" && t != "search.com" && t != "test.com")
        {
            clearCurrentWindow();
            noPageWindow.localScale = new Vector3(1, 1, 1);
            noPageShowing = true;
        }
    }

    private void refreshUrl()
    {
        if (currentTab == 0) {
            loadSearchTab();
        } else if (currentTab == 1) {
            loadMapTab();
        }
    }

    private void clearCurrentWindow() 
    {
        if (noPageShowing) {
            noPageWindow.localScale = new Vector3(0, 1, 1);
            noPageShowing = false;
        }
        else if (puzzlePageShowing)
        {
            puzzleWindow.localScale = new Vector3(0, 1, 1);
            puzzleWindow1.localScale = new Vector3(0, 1, 1);
            puzzleWindow2.localScale = new Vector3(0, 1, 1);
            puzzleWindow3.localScale = new Vector3(0, 1, 1);
            puzzlePageShowing = false;
        }
        else if (currentTab == 0) {
            searchWindow.localScale = new Vector3(0, 1, 1);
            Color col = searchBtn.GetComponent<Image>().color;
            col.a = 100/255f;
            searchBtn.GetComponent<Image>().color = col;
        }
        else if (currentTab == 1) {
            mapWindow.localScale = new Vector3(0, 1, 1);
            Color col = mapBtn.GetComponent<Image>().color;
            col.a = 100/255f;
            mapBtn.GetComponent<Image>().color = col;
        }
    }
}
