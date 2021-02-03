using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public static GameObject TextField;

    public static void TestFunction()
    {
        TextField = GameObject.Find("Text");
        // Obtain the current time.
        string currentTime;
        currentTime = Time.time.ToString("f6");
        currentTime = "Time is: " + currentTime + " sec.";
        //TextField.GetComponent<Text>().text = (1 + 1).ToString();
        TextField.GetComponent<Text>().text = currentTime;
        // Toggle TextField to update text
        TextField.SetActive(false);
        TextField.SetActive(true);
        //Debug.Log(1 + 1);
        Debug.Log(currentTime);
    }
}