using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour
{
    void Update()
    {
        Close();
    }

    void Close()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}