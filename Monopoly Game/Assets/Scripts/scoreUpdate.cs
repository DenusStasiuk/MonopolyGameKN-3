using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    public Text score;
    public static int points=0;
    // Start is called before the first frame update
    void Start()
    {
        //points = 0;
    }
     
    

    //public static void ScoreUp() { points++; 
    //}
    void Update()
    {
        score.text = "Score: " + points.ToString();
    }
}
