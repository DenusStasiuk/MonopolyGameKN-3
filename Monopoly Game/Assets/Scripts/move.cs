
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    static List<Vector3> fields = new List<Vector3>();
    public static int rand = 0;
    public static int pos = 0;
    public static bool check_move;
    static Vector3 v = new Vector3(61.7f, 23.5f);
    void Start()
    {

        fields.Add(new Vector3(61.7f, 23.5f));
        fields.Add(new Vector3(60.4f, 23.5f));
        fields.Add(new Vector3(58.8f, 23.5f));
        fields.Add(new Vector3(57.2f, 23.5f));
        fields.Add(new Vector3(56.2f, 23.5f));
        fields.Add(new Vector3(55.0f, 23.5f));
        fields.Add(new Vector3(53.5f, 23.5f));
        fields.Add(new Vector3(53.5f, 24.9f));
        fields.Add(new Vector3(53.5f, 26.4f));
        fields.Add(new Vector3(53.5f, 27.6f));
        fields.Add(new Vector3(53.5f, 28.7f));
        fields.Add(new Vector3(53.5f, 30.3f));
        fields.Add(new Vector3(53.5f, 31.7f));
        fields.Add(new Vector3(54.9f, 31.7f));
        fields.Add(new Vector3(56.5f, 31.7f));
        fields.Add(new Vector3(57.6f, 31.7f));
        fields.Add(new Vector3(58.8f, 31.7f));
        fields.Add(new Vector3(60.2f, 31.7f));
        fields.Add(new Vector3(61.8f, 31.7f));
        fields.Add(new Vector3(61.8f, 30.3f));
        fields.Add(new Vector3(61.8f, 29.1f));
        fields.Add(new Vector3(61.8f, 28.0f));
        fields.Add(new Vector3(61.8f, 26.45f));
        fields.Add(new Vector3(61.8f, 25f));
        //v = fields[0];

    }
    void Update()
    {

        transform.position = v;
        if (v == fields[1] || v == fields[8] || v == fields[17] || v == fields[19])
        {
            showQuestion.nextQuestion = 1;
        }
        else if (v == fields[2] || v == fields[3] || v == fields[13] || v == fields[21])
        {
            showQuestion.nextQuestion = 2;
        }
        else if (v == fields[5] || v == fields[7] || v == fields[10] || v == fields[16])
        {
            showQuestion.nextQuestion = 3;
        }
        else if (v == fields[11] || v == fields[14] || v == fields[22] || v == fields[23])
        {
            showQuestion.nextQuestion = 4;
        }

        bool checkFields()
        {
            foreach (Vector3 t in fields)
            {
                if (t == v)
                {
                    return true;
                }
            }
            return false;
        }

        if ( check_move &&
            ( v != fields[0] 
            && v!=fields[4] 
            && v != fields[6] 
            && v != fields[9] 
            && v != fields[12] 
            && v != fields[15] 
            && v != fields[18] 
            && v != fields[20]))
        {
            check_move = false;
            SceneManager.LoadScene(1);
            //Application.LoadLevel("сhooseAnswear");
        }


    }
    public static void moveFishka ()
    {
        if ((rand + pos) > fields.Count) {
            v = fields[(rand + pos) - fields.Count];
            //transform.position = v;
            pos = (rand + pos) - fields.Count;
        }
        else if((rand+pos)<fields.Count)
        {
            v = fields[rand + pos];
            //transform.position = v;
            pos += rand;
        }
    }
}
