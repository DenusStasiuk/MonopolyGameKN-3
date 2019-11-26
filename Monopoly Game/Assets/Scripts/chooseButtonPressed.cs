using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseButtonPressed : MonoBehaviour
{
    public GameObject button;
    public static int buttonNum;
    void OnMouseUpAsButton()
    {
        if (button.name.Equals("choose_button1")) {
            buttonNum = 1;
           // scoreUpdate.ScoreUp();
            SceneManager.LoadScene(0);

        }
        else if (button.name.Equals("choose_button2")) {
           // scoreUpdate.ScoreUp();
            buttonNum = 2; SceneManager.LoadScene(0);
        }
        else if (button.name.Equals("choose_button3")) {
           // scoreUpdate.ScoreUp();
            buttonNum = 3; SceneManager.LoadScene(0);
        }

        SceneManager.LoadScene(0);
        // Console.WriteLine("Button pressed");
        Debug.Log("Button presed");
    }
}
