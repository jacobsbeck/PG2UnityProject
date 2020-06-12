using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Globalization;

public class SearchController : MonoBehaviour
{
    public UnityEngine.UI.Button searchButton;
    public InputField searchTxt;
    public RectTransform searchWindow;
    public RectTransform profileWindow;

    public RectTransform searchContainer;
    public GameObject resultContainer;

    public RectTransform historyContainer;
    public GameObject callContainer;
    public Text noResults;

    public RectTransform profileContainer;
    private List<UserData> savedUsers = new List<UserData>();
    private string[] startUsers = { "Lydia Davis/1992-07-25", "Kyle Johnson/2016-11-03", "Jake Davis/2018-05-02"};

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(DateTime.Now);
        searchButton.onClick.AddListener(searchForUser);
        CallData hid = new CallData();
        hid.initalize("Found", "Me", 9999999999, DateTime.Now, 99);
        CallData[] c = {hid};
        for (int i = 0; i < startUsers.Length; i++) {
            UserData testUser = new UserData();
            DateTime d = DateTime.Parse(startUsers[i].Split('/')[1]);
            testUser.initalize(startUsers[i].Split('/')[0].Split(' ')[0], startUsers[i].Split('/')[0].Split(' ')[1], getRandomNumber(), d, c);
            savedUsers.Add(testUser);
        }
        UserData mapUser = new UserData();
        DateTime d1 = getRandomBirthdate();
        mapUser.initalize("Tom", "Thomas", 2062164761, d1, c);
        savedUsers.Add(mapUser);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void searchForUser()
    {
        clearSearchResults();
        List<UserData> users = new List<UserData>();
        bool useNumber = false;
        int nameSearched = validateName();
        long numSearched = validateNumber();
        string curName = "";
        if (numSearched != -99999999999)
        {
            if (numberIsSaved(numSearched) != null) {
                users.Add(numberIsSaved(numSearched));
            }
            useNumber = true;
        }
        else if (nameSearched != 0)
        {
            curName = searchTxt.text;
            users = nameIsSaved(curName, nameSearched);
        }
        else {
            noResults.rectTransform.localScale = new Vector3(1, 1, 1);
            return;
        }

        if (users.Count == 0)
        {
            int k = 1;
            if (!useNumber && nameSearched != 3)
            {
                k = UnityEngine.Random.Range(1, 15);
            }
            if (k <= 7) {
                searchContainer.sizeDelta = new Vector2(1000, 350);
            }
            searchContainer.sizeDelta = new Vector2(1000, 50 * k);
            for (int j = 0; j < k; j++)
            {
                int numCalls = UnityEngine.Random.Range(0, 10);
                UserData user = new UserData();
                if (!useNumber)
                {
                    if (nameSearched == 1)
                    {
                        string tempLast = getRandomLastName();
                        user.initalize(FirstLetterToUpper(curName), tempLast, getRandomNumber() ,getRandomBirthdate(), new CallData[numCalls]);
                    }
                    else if (nameSearched == 2)
                    {
                        string tempFirst = getRandomFirstName();
                        user.initalize(tempFirst, FirstLetterToUpper(curName), getRandomNumber(), getRandomBirthdate(), new CallData[numCalls]);
                    }
                    else if (nameSearched == 3)
                    {
                        user.initalize(FirstLetterToUpper(curName.Split(' ')[0]), FirstLetterToUpper(curName.Split(' ')[1]), getRandomNumber(), getRandomBirthdate(), new CallData[numCalls]);
                    }
                }
                else
                {
                    user.initalize(getRandomFirstName(), getRandomLastName(), numSearched, getRandomBirthdate(), new CallData[numCalls]);
                }

                //historyContainer.sizeDelta = new Vector2(700, 50 * numCalls);
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
                        str = previousCall.firstName + " " + previousCall.lastName;
                        n = previousCall.number;
                    }
                    else
                    {
                        str = getRandomFirstName() + " " + getRandomLastName();
                        n = getRandomNumber();
                    }
                    curCall.initalize(str.Split(' ')[0], str.Split(' ')[1], n, getRandomDate(t), UnityEngine.Random.Range(0, 100));
                    previousCall = curCall;
                    user.calls[i] = curCall;
                }
                savedUsers.Add(user);
                users.Add(user);
            }
        }

        for (int i = 0; i < users.Count; i++)
        {
            GameObject r = Instantiate(resultContainer);
            r.GetComponent<ResultController>().user = users[i];
            r.transform.GetChild(0).GetComponent<Text>().text = users[i].firstName + " " + users[i].lastName;
            r.transform.GetChild(1).GetComponent<Text>().text = users[i].number.ToString();
            r.transform.SetParent(searchContainer);
            r.transform.localPosition = new Vector3(500, -50 * i - 25, 0);
        }

        //profileContainer.GetChild(0).GetComponent<Text>().text = user.name;
        //profileContainer.GetChild(1).GetComponent<Text>().text = user.number.ToString();
        //profileContainer.GetChild(2).GetComponent<Text>().text = user.birthday.ToString();
        /*
        if (numSearched)
        {
            user = numberIsSaved(curNumber);
        }
        else if (nameSearched == 3)
        {
            user = nameIsSaved();
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
            call.transform.GetChild(2).GetComponent<Text>().text = user.calls[i].date.ToString("D", CultureInfo.CreateSpecificCulture("en-US"));
            call.transform.GetChild(3).GetComponent<Text>().text = user.calls[i].duration.ToString() + "mins";
            call.transform.SetParent(historyContainer);
            call.transform.localPosition = new Vector3(350, -50 * i - 25, 0);
        }

        profileContainer.GetChild(0).GetComponent<Text>().text = user.name;
        profileContainer.GetChild(1).GetComponent<Text>().text = user.number.ToString();
        profileContainer.GetChild(2).GetComponent<Text>().text = user.birthday.ToString();
        */
    }

    public string FirstLetterToUpper(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToUpper(str[0]) + str.Substring(1);

        return str.ToUpper();
    }

    private string getRandomFirstName()
    {
        string[] linesFirst = FileData.firstNames;

        return linesFirst[UnityEngine.Random.Range(0, linesFirst.Length)];
    }

    private string getRandomLastName()
    {
        string[] linesLast = FileData.lastNames;
        return linesLast[UnityEngine.Random.Range(0, linesLast.Length)];
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
        t = t.AddYears(UnityEngine.Random.Range(-90, -18));
        return t;
    }

    private long validateNumber()
    {
        string numberToCheck = searchTxt.text;
        numberToCheck.Replace("-", "");
        numberToCheck.Replace(" ", "");
        long cur = 0;
        if (numberToCheck.Length == 10)
        {
            if (long.TryParse(numberToCheck, out cur)) {
                return cur;
            }
        }
        return -99999999999;
    }

    private int validateName()
    {
        bool firstNameValid = false;
        bool lastNameValid = false;
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
        if (searchTxt.text.Split(' ').Length == 2)
        {
            string[] linesLast = FileData.lastNames;
            for (int i = 0; i < linesLast.Length; i++)
            {
                if (linesLast[i].ToLower() == searchTxt.text.Split(' ')[1].ToLower())
                {
                    lastNameValid = true;
                    break;
                }
            }
        } else if (firstNameValid != true) {
            string[] linesLast = FileData.lastNames;
            for (int i = 0; i < linesLast.Length; i++)
            {
                if (linesLast[i].ToLower() == searchTxt.text.Split(' ')[0].ToLower())
                {
                    lastNameValid = true;
                    break;
                }
            }
        }

        if (firstNameValid && lastNameValid)
        {
            return 3;
        }
        else if (firstNameValid) {
            return 1;
        }
        else if (lastNameValid)
        {
            return 2;
        }
        return 0;
    }

    private List<UserData> nameIsSaved(string nameSearched, int nameInput)
    {
        List<UserData> u = new List<UserData>();
        foreach (UserData user in savedUsers)
        {
            if (nameInput == 1)
            {
                if (user.firstName.ToLower().Equals(nameSearched.ToLower()))
                {
                    u.Add(user);
                }
            }
            else if (nameInput == 2)
            {
                if (user.lastName.ToLower().Equals(nameSearched.ToLower()))
                {
                    u.Add(user);
                }
            } else if (nameInput == 3){
                if (user.firstName.ToLower().Equals(nameSearched.ToLower().Split(' ')[0]) && user.lastName.ToLower().Equals(nameSearched.ToLower().Split(' ')[1]))
                {
                    u.Add(user);
                    Debug.Log(user.firstName + " " + user.lastName);
                }
            }
        }
        return u;
    }

    private UserData numberIsSaved(long numSearched)
    {
        foreach (UserData user in savedUsers)
        {
            if (user.number.Equals(numSearched))
            {
                return user;
            }
        }
        return null;
    }

    private void clearSearchResults()
    {
        noResults.rectTransform.localScale = new Vector3(0, 1, 1);
        profileWindow.transform.localScale = new Vector3(0, 1, 1);
        searchWindow.transform.localScale = new Vector3(1, 1, 1);
        foreach (Transform child in searchContainer)
        {
            Destroy(child.gameObject);
        }
        foreach (Transform child in historyContainer)
        {
            Destroy(child.gameObject);
        }
        historyContainer.sizeDelta = new Vector2(700, 300);
        profileContainer.GetChild(0).GetComponent<Text>().text = "None";
        profileContainer.GetChild(1).GetComponent<Text>().text = "None";
        profileContainer.GetChild(2).GetComponent<Text>().text = "None";
    }
}

public class UserData
{
    public string firstName;
    public string lastName;
    public long number;
    public DateTime birthday;
    public CallData[] calls;

    public void initalize(string first, string last, long num, DateTime b, CallData[] c)
    {   
        firstName = first;
        lastName = last;
        number = num;
        birthday = b;
        calls = c;
    }
}

public class CallData
{
    public string firstName;
    public string lastName;
    public long number;
    public DateTime date;
    public int duration;

    public void initalize(string first, string last, long num, DateTime d, int dur)
    {
        firstName = first;
        lastName = last;
        number = num;
        date = d;
        duration = dur;
    }
}

