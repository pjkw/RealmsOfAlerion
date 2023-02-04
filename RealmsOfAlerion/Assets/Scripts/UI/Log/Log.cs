using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Log : MonoBehaviour
{
    public Text text;

    public void LogMessage(string message)
    {
        text.text = message;
    }
}
