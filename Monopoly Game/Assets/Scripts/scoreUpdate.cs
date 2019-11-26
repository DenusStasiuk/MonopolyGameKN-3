using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    static int Score=0;
    
    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 400, 400), "Score: "+ Score);
    }

    public static void ScoreUp() { Score++; }
    void Update()
    {
        
    }
}
