using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Globalization;

public class ResultController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public UserData user;
    private RectTransform profileWindow;
    private RectTransform searchWindow;

    private RectTransform historyContainer;
    private GameObject callContainer;

    private RectTransform profileContainer;

    // Start is called before the first frame update
    void Start()
    {
        profileWindow = GameObject.Find("ProfileWindow").GetComponent<RectTransform>();
        searchWindow = GameObject.Find("SearchResults").GetComponent<RectTransform>();
        historyContainer = GameObject.Find("ScrollContainer").GetComponent<RectTransform>();
        callContainer = Resources.Load("CallContainer") as GameObject;
        profileContainer = GameObject.Find("Profile").GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData data)
    {
        Color temp = GetComponent<Image>().color;
        temp.a = 1;
        GetComponent<Image>().color = temp;
    }

    public void OnPointerExit(PointerEventData data)
    {
        Color temp = GetComponent<Image>().color;
        temp.a = 100f / 255f;
        GetComponent<Image>().color = temp;
    }

    public void OnPointerDown(PointerEventData data)
    {
        profileWindow.localScale = new Vector3(1, 1, 1);
        searchWindow.localScale = new Vector3(0, 1, 1);
        for (int i = 0; i < user.calls.Length; i++)
        {
            GameObject call = Instantiate(callContainer);
            call.transform.GetChild(0).GetComponent<Text>().text = user.calls[i].firstName + " " + user.calls[i].lastName;
            call.transform.GetChild(1).GetComponent<Text>().text = user.calls[i].number.ToString();
            call.transform.GetChild(2).GetComponent<Text>().text = user.calls[i].date.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
            call.transform.GetChild(3).GetComponent<Text>().text = user.calls[i].duration.ToString() + "mins";
            call.transform.SetParent(historyContainer);
            call.transform.localPosition = new Vector3(350, -50 * i - 25, 0);
        }

        profileContainer.GetChild(0).GetComponent<Text>().text = user.firstName + " " + user.lastName;
        profileContainer.GetChild(1).GetComponent<Text>().text = user.number.ToString();
        profileContainer.GetChild(2).GetComponent<Text>().text = user.birthday.ToString();

    }
}
