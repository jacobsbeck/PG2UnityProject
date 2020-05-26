using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SearchController : MonoBehaviour
{
    public Button searchButton;
    public InputField searchTxt;
    public RectTransform historyContainer;
    public GameObject callContainer;
    public Text noResults;

    public RectTransform profileContainer;
    private long curNumber = 0;
    private string curName = "";
    private List<UserData> savedUsers = new List<UserData>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DateTime.Now);
        searchButton.onClick.AddListener(searchForUser);
        CallData callTest = new CallData();
        callTest.initalize("Found Me", 9999999999, DateTime.Now, 99);
        UserData testUser = new UserData();
        CallData[] c = {callTest};
        testUser.initalize("Hidden", 9999999999, DateTime.Now, c);
        savedUsers.Add(testUser);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void searchForUser()
    {
        clearSearchResults();
        UserData user = new UserData();
        bool useName = false;
        if (validateNumber())
        {
            user = numberIsSaved();
        }
        else if (validateName())
        {
            user = userIsSaved();
            useName = true;
        }
        else {
            noResults.rectTransform.localScale = new Vector3(1, 1, 1);
            return;
        }

        if (user == null)
        {
            int numCalls = UnityEngine.Random.Range(0, 10);
            user = new UserData();
            if (!useName)
            {
                user.initalize(getRandomName(), curNumber, getRandomBirthdate(), new CallData[numCalls]);
            } else {
                user.initalize(curName, getRandomNumber(), getRandomBirthdate(), new CallData[numCalls]);
            }
            historyContainer.sizeDelta = new Vector2(700, 50 * numCalls);
            DateTime t = DateTime.Now;
            CallData previousCall = null;
            for (int i = 0; i < numCalls; i++)
            {
                CallData curCall = new CallData();
                int check = UnityEngine.Random.Range(0, 2);
                string str = "";
                long n = 0;
                if (check == 0 && previousCall != null)
                {
                    str = previousCall.name;
                    n = previousCall.number;
                }
                else
                {
                    str = getRandomName();
                    n = getRandomNumber();
                }
                curCall.initalize(str, n, getRandomDate(t), UnityEngine.Random.Range(0, 100));
                previousCall = curCall;
                user.calls[i] = curCall;
            }
            savedUsers.Add(user);
        }

        for (int i = 0; i < user.calls.Length; i++)
        {
            GameObject call = Instantiate(callContainer);
            call.transform.GetChild(0).GetComponent<Text>().text = user.calls[i].name;
            call.transform.GetChild(1).GetComponent<Text>().text = user.calls[i].number.ToString();
            call.transform.GetChild(2).GetComponent<Text>().text = user.calls[i].date.ToString();
            call.transform.GetChild(3).GetComponent<Text>().text = user.calls[i].duration.ToString() + "mins";
            call.transform.SetParent(historyContainer);
            call.transform.localPosition = new Vector3(350, -50 * i - 25, 0);
        }

        profileContainer.GetChild(0).GetComponent<Text>().text = user.name;
        profileContainer.GetChild(1).GetComponent<Text>().text = user.number.ToString();
        profileContainer.GetChild(2).GetComponent<Text>().text = user.birthday.ToString();
    }

    private string getRandomName()
    {
        string[] linesFirst = FileData.firstNames;
        string[] linesLast = FileData.lastNames;

        return linesFirst[UnityEngine.Random.Range(0, linesFirst.Length)] + " " +
            linesLast[UnityEngine.Random.Range(0, linesLast.Length)];
    }

    private long getRandomNumber()
    {
        int check = UnityEngine.Random.Range(0, 2);
        string s = "";
        for (int i = 0; i < 7; i++) {
            s = s + UnityEngine.Random.Range(0, 9).ToString();
        }
        if (check == 0)
        {
            s = "425" + s;
        }
        else
        {
            s = "206" + s;
        }
        return long.Parse(s);
    }

    private DateTime getRandomDate(DateTime t)
    {
        t = t.AddSeconds(UnityEngine.Random.Range(-60, 0));
        t = t.AddMinutes(UnityEngine.Random.Range(-30, 0));
        t = t.AddHours(UnityEngine.Random.Range(-10, 0));
        t = t.AddDays(UnityEngine.Random.Range(-5, 0));
        t = t.AddMonths(UnityEngine.Random.Range(-3, 0));
        return t;
    }

    private DateTime getRandomBirthdate()
    {
        DateTime t = DateTime.Now;
        t = t.AddSeconds(UnityEngine.Random.Range(-60, 0));
        t = t.AddMinutes(UnityEngine.Random.Range(-60, 0));
        t = t.AddHours(UnityEngine.Random.Range(-24, 0));
        t = t.AddDays(UnityEngine.Random.Range(-7, 0));
        t = t.AddMonths(UnityEngine.Random.Range(-12, 0));
        t = t.AddYears(UnityEngine.Random.Range(-60, -18));
        return t;
    }

    private bool validateNumber()
    {
        string numberToCheck = searchTxt.text;
        numberToCheck.Replace("-", "");
        numberToCheck.Replace(" ", "");
        if (numberToCheck.Length == 10)
        {
            return long.TryParse(numberToCheck, out curNumber);
        }
        return false;
    }

    private bool validateName()
    {
        bool firstNameValid = false;
        bool lastNameValid = false;
        if (searchTxt.text.Split(' ').Length == 2)
        {
            //Read the text from directly from the test.txt file
            string[] linesFirst = FileData.firstNames;
            for (int i = 0; i < linesFirst.Length; i++)
            {
                if (linesFirst[i].ToLower() == searchTxt.text.Split(' ')[0].ToLower())
                {
                    firstNameValid = true;
                    break;
                }
            }

            string[] linesLast = FileData.lastNames;
            for (int i = 0; i < linesLast.Length; i++)
            {
                if (linesLast[i].ToLower() == searchTxt.text.Split(' ')[1].ToLower())
                {
                    lastNameValid = true;
                    break;
                }
            }
        }

        if  (firstNameValid && lastNameValid) {
            curName = searchTxt.text;
            return true;
        } else {
            foreach (UserData user in savedUsers)
            {
                if (user.name.Equals(searchTxt.text))
                {
                    curName = searchTxt.text;
                    return true;
                }
            }
            return false;
        }
    }

    private UserData userIsSaved()
    {
        foreach (UserData user in savedUsers)
        {
            if (user.name.Equals(curName))
            {
                return user;
            }
        }
        return null;
    }

    private UserData numberIsSaved()
    {
        foreach (UserData user in savedUsers)
        {
            if (user.number.Equals(curNumber))
            {
                return user;
            }
        }
        return null;
    }

    private void clearSearchResults()
    {
        noResults.rectTransform.localScale = new Vector3(0, 1, 1);
        foreach (Transform child in historyContainer)
        {
            Destroy(child.gameObject);
        }
        historyContainer.sizeDelta = new Vector2(700, 200);
        profileContainer.GetChild(0).GetComponent<Text>().text = "Name";
        profileContainer.GetChild(1).GetComponent<Text>().text = "Number";
        profileContainer.GetChild(2).GetComponent<Text>().text = "Birthdate";
    }
}

public class UserData
{
    public string name;
    public long number;
    public DateTime birthday;
    public CallData[] calls;

    public void initalize(string na, long num, DateTime b, CallData[] c)
    {
        name = na;
        number = num;
        birthday = b;
        calls = c;
    }
}

public class CallData
{
    public string name;
    public long number;
    public DateTime date;
    public int duration;

    public void initalize(string n, long num, DateTime d, int dur)
    {
        name = n;
        number = num;
        date = d;
        duration = dur;
    }
}
