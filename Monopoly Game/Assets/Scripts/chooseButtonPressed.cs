using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chooseButtonPressed : MonoBehaviour
{
    void OnMouseDown()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x + 0.2f, t.y + 0.2f, 1f);
    }
    void OnMouseUp()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x - 0.2f, t.y - 0.2f, 1f);
    }
    public GameObject button;
    public static int buttonNum;
    void OnMouseUpAsButton()
    {
        if (button.name.Equals("1")) {
             buttonNum = 1;
            if (showQuestion.checkCorectAnswear(0))
            {
                if (move.nextFishka == 1)
                {
                    scoreUpdate.wPoints++;
                }else if (move.nextFishka == 2)
                {
                    scoreUpdate.bPoints++;
                }
            }

            SceneManager.LoadScene(0, LoadSceneMode.Single);

        }
         else if (button.name.Equals("2")) {
            if (showQuestion.checkCorectAnswear(1))
            {
                if (move.nextFishka == 1)
                {
                    scoreUpdate.wPoints++;
                }
                else if (move.nextFishka == 2)
                {
                    scoreUpdate.bPoints++;
                }
            }
            buttonNum = 2; SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
         else if (button.name.Equals("3")) {
            if (showQuestion.checkCorectAnswear(2))
            {
                if (move.nextFishka == 1)
                {
                    scoreUpdate.wPoints++;
                }
                else if (move.nextFishka == 2)
                {
                    scoreUpdate.bPoints++;
                }
            }
            buttonNum = 3; SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
         
        //scoreUpdate.points++;
        //SceneManager.LoadScene(0);
        // Console.WriteLine("Button pressed");
        Debug.Log("Button presed");
    }
}
