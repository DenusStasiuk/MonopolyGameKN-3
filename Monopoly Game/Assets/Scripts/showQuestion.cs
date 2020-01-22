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
        qBlue.Add(new Question(1, "C# це ... мова програмування", new List<string> { "об'єктно орієнтована", "функціональна", "державна" }, 0));
        qBlue.Add(new Question(1, "В C# клас може успадковувати кілька ___", new List<string> { "Класів", "Інтерфейсів ", "Абстрактних класів" }, 1));
        qBlue.Add(new Question(1, "Struct - це _____.", new List<string> { "Reference type", "Value type ", "String type" }, 1));
        qBlue.Add(new Question(1, "Який із наведених типів даних можна використовувати із enum?", new List<string> { "Int ", "String", "Boolean" }, 0));
        qBlue.Add(new Question(1, "Яке призначення індексатору:", new List<string> { "Створює індекс для екземпляру класу.", "Дозволяє індексувати екземпляр класу, як масив.", "Дозволяє нумерувати класи." }, 1));

        qRed.Add(new Question(2, "Red Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qRed.Add(new Question(2, "Що робить наступний код?: def a(b, c, d): pass", new List<string> { "Визначає список і ініціалізує його."
            , "Визначає функцію, яка нічого не робить.", "Визначає функцію, яка передає параметри." }, 1));
        qRed.Add(new Question(2, "Що буде надруковано? name = \"snow storm\"\nprint(\"%s\" % \nname[6:8])", new List<string> { "sto", "to ", "Syntax Error" }, 1));
        qRed.Add(new Question(2, "Що буде надруковано? kvps = { \"user\", \"bill\", \"password\", \"hillary\" }\nprint(kvps['password'])", new List<string> { "user", "password", "TypeError " }, 2));
        qRed.Add(new Question(2, "Що виведе наступний код, при його виконанні? Використовується Python 3.x.\nprint(type(1 / 2))", new List<string> { "type int", "type float", "type double" }, 1));

        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));
        qGreen.Add(new Question(3, "Green Java is ... programing language?", new List<string> { "OOP", "functional", "national" }, 0));

        qYelow.Add(new Question(4, "Java це ... мова програмування", new List<string> { "об'єктно орієнтована", "функціональна", "державна" }, 0));
        qYelow.Add(new Question(4, "Скільки класів може наслідувати клас в Java?", new List<string> { "два", "безліч", "один" }, 2));
        qYelow.Add(new Question(4, "String в Java - це ____?", new List<string> { "примітив", "об'єкт", "окрема структура" }, 1));
        qYelow.Add(new Question(4, "Для чого використовується функція equals в Java?", new List<string> { "Для порівняння кількості символів в стоці", "Для посимвольного порівняння строк", "для порівняння змінних типу int" }, 1));
        qYelow.Add(new Question(4, "Що буде надруковано? int a=2; System.out.println(++a++);", new List<string> { "4", "2", "3" }, 2));
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
        Debug.Log("next q "+nextQuestion.ToString());
    }
    public static bool checkCorectAnswear(int button)
    {
        if(nextQuestion ==1)
        {
            if (button == qBlue[nextB].corectAnswear) {
                if (nextB+1 > qBlue.Count - 1) { nextB = 0; }
                else if (nextB + 1 <= qBlue.Count - 1) { nextB++; }
                return true;
            }
        }
        else if(nextQuestion == 2)
        {
            if (button == qRed[nextR].corectAnswear)
            {
                if(nextR+1 > qRed.Count - 1) { nextR = 0; }
                else if(nextR+1 <= qRed.Count-1) { nextR++; }
                return true;
            }
        }
        else if (nextQuestion == 3)
        {
            if(button== qGreen[nextG].corectAnswear)
            {
                if(nextG+1 > qGreen.Count-1) { nextG = 0; }
                else if(nextG+1 <= qGreen.Count-1) { nextG++; }
                return true;
            }
        }
        else if (nextQuestion == 4)
        {
            if (button == qYelow[nextY].corectAnswear)
            {
                if(nextY+1 > qYelow.Count-1) { nextY = 0; }
                else if(nextY+1 <= qYelow.Count-1) { nextY++; }
                return true;
            }
        }
        return false;
    }
}
