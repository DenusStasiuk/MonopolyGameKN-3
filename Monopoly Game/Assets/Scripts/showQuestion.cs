using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showQuestion : MonoBehaviour
{
    public Text question;
    public Text answear1;
    public Text answear2;
    public Text answear3;

    private static List<Question> qBlue = new List<Question>();
    private static List<Question> qRed = new List<Question>();
    private static List<Question> qGreen = new List<Question>();
    private static List<Question> qYelow = new List<Question>();
    public static int nextQuestion=1;// type 1,2,3,4
    private static int nextB=0;//next from list
    private static int nextR=0;
    private static int nextG=0;
    private static int nextY=0;
    void Start()
    {
        //List<string> a = new List<string>();
        //a.Add("OOP");
        //a.Add("functional");
        //a.Add("national");
        qBlue.Add(new Question(1, "Blue Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qRed.Add(new Question(2, "Red Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qYelow.Add(new Question(4, "Yelow Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
    }

    
    void Update()
    {
       
        if (nextQuestion == 1)
        {
            question.text = qBlue[nextB].question;
            answear1.text = qBlue[nextB].ansvears[0];
            answear2.text = qBlue[nextB].ansvears[1];
            answear3.text = qBlue[nextB].ansvears[2];
        }
        else if (nextQuestion == 2)
        {
            question.text = qRed[nextR].question;
            answear1.text = qRed[nextR].ansvears[0];
            answear2.text = qRed[nextR].ansvears[1];
            answear3.text = qRed[nextR].ansvears[2];

        }
        else if (nextQuestion==3)
        {
            question.text = qGreen[nextG].question;
            answear1.text = qGreen[nextG].ansvears[0];
            answear2.text = qGreen[nextG].ansvears[1];
            answear3.text = qGreen[nextG].ansvears[2];
        }
        else if (nextQuestion == 4)
        {
            question.text = qYelow[nextY].question;
            answear1.text = qYelow[nextY].ansvears[0];
            answear2.text = qYelow[nextY].ansvears[1];
            answear3.text = qYelow[nextY].ansvears[2];

        }
    }
    public static bool checkCorectAnswear(int button)
    {
        if(nextQuestion ==1)
        {
            if (button == qBlue[nextB].corectAnswear) {
                if (nextB+1 > qBlue.Count) { nextB = 0; }
                else if (nextB + 1 <= qBlue.Count) { nextB++; }
                return true;
            }
        }
        else if(nextQuestion == 2)
        {
            if (button == qRed[nextR].corectAnswear)
            {
                if(nextR+1 > qRed.Count) { nextR = 0; }
                else if(nextR+1 <= qRed.Count) { nextR++; }
                return true;
            }
        }
        else if (nextQuestion == 3)
        {
            if(button== qGreen[nextG].corectAnswear)
            {
                if(nextG+1 > qGreen.Count) { nextG = 0; }
                else if(nextG+1 <= qGreen.Count) { nextG++; }
                return true;
            }
        }
        else if (nextQuestion == 4)
        {
            if (button == qYelow[nextY].corectAnswear)
            {
                if(nextY+1 > qYelow.Count) { nextY = 0; }
                else if(nextY+1 <= qYelow.Count) { nextY++; }
                return true;
            }
        }
        return false;
    }
}
