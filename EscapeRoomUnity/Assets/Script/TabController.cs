﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    public UnityEngine.UI.Button searchBtn;
    public UnityEngine.UI.Button mapBtn;
    public UnityEngine.UI.Button helpBtn;

    public UnityEngine.UI.Button loadUrlBtn;
    public UnityEngine.UI.Button refreshUrlBtn;

    public RectTransform searchWindow;
    public RectTransform mapWindow;
    public RectTransform helpWindow;

    public RectTransform noPageWindow;
    public RectTransform puzzleWindowBook;
    public RectTransform puzzleWindowWall;

    public InputField urlText;
    private int currentTab = 0;
    private bool noPageShowing = false;
    private bool puzzlePageShowing = false;

    public AudioSource clickAudio;
    // Start is called before the first frame update
    void Start()
    {
        searchBtn.onClick.AddListener(loadSearchTab);
        mapBtn.onClick.AddListener(loadMapTab);
        helpBtn.onClick.AddListener(loadHelpTab);
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
        if (Input.GetMouseButtonDown(0)) {
            clickAudio.Play();
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

    private void loadHelpTab()
    {
        clearCurrentWindow();
        currentTab = 2;
        helpWindow.localScale = new Vector3(1, 1, 1);
        Color col = helpBtn.GetComponent<Image>().color;
        col.a = 1;
        helpBtn.GetComponent<Image>().color = col;
        urlText.text = "www.help.com";
    }

    private void loadUrl() {
        string t = urlText.text.Replace("www.", "");
        clearCurrentWindow();
        if (t == "bluelodge.com")
        {
            puzzleWindowWall.localScale = new Vector3(1, 1, 1);
            puzzlePageShowing = true;
        }
        else if (t == "slusho.com")
        {
            puzzleWindowBook.localScale = new Vector3(1, 1, 1);
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
        else if (t == "help.com")
        {
            loadHelpTab();
        }

        else if (t != "help.com" && t != "map.com" && t != "search.com" && t != "bluelodge.com" && t != "slusho.com")
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
        } else if (currentTab == 2) {
            loadHelpTab();
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
            puzzleWindowBook.localScale = new Vector3(0, 1, 1);
            puzzleWindowWall.localScale = new Vector3(0, 1, 1);
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
        else if (currentTab == 2)
        {
            helpWindow.localScale = new Vector3(0, 1, 1);
            Color col = helpBtn.GetComponent<Image>().color;
            col.a = 100 / 255f;
            helpBtn.GetComponent<Image>().color = col;
        }
    }
}
