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
            if (showQuestion.checkCorectAnswear(0))
            {
                scoreUpdate.points++;
            }

            SceneManager.LoadScene(0, LoadSceneMode.Single);

        }
         else if (button.name.Equals("choose_button2")) {
            if (showQuestion.checkCorectAnswear(1))
            {
                scoreUpdate.points++;
            }
            buttonNum = 2; SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
         else if (button.name.Equals("choose_button3")) {
            if (showQuestion.checkCorectAnswear(2))
            {
                scoreUpdate.points++;
            }
            buttonNum = 3; SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
         
        //scoreUpdate.points++;
        //SceneManager.LoadScene(0);
        // Console.WriteLine("Button pressed");
        Debug.Log("Button presed");
    }
}
