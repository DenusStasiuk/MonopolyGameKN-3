using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUpdate : MonoBehaviour
{
    public Text score;
    public static int wPoints=0;
    public static int bPoints=0;
    // Start is called before the first frame update
    void Start()
    {
        //points = 0;
    }
     
    

    //public static void ScoreUp() { points++; 
    //}
    void Update()
    {
        score.text = "Бали гравця 1: " + wPoints.ToString()+"\nБали гравця 2: " +bPoints.ToString();
    }
}
