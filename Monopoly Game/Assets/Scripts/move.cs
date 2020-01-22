
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{
    static List<Vector3> fields = new List<Vector3>();
    public static int rand1 = 0;
    public static int pos1 = 0;
    public static int rand2 = 0;
    public static int pos2 = 0;
    public static bool check_move1=false;
    public static bool check_move2=false;

    public GameObject fishka;
    public GameObject fishkaBlack;
    public static int nextFishka=1;
    static Vector3 b = new Vector3(61.9f, 23.5f);
    static Vector3  w = new Vector3(61.5f, 23.5f);
    
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
        fields.Add(new Vector3(61.8f, 25.0f));
        //v = fields[0];

    }
    static bool stop = true;
    //float step = 0.8f * Time.deltaTime;

    void Update()
    {
        
        
            float step = 0.8f * Time.deltaTime;
           
                //transform.position = v;
                if (w == fishka.transform.position) { stop = false; }
                if (fishka.transform.position != w && !check_move1) { fishka.transform.position = w; Debug.Log("move1_63"); }
                if (fishka.transform.position != w && check_move1)
                {
                    transform.position = Vector3.MoveTowards(fishka.transform.position, w, step);
            Debug.Log("move1_67");

        }

        if (nextFishka == 1)
        {
            if (w == fields[1] || w == fields[8] || w == fields[17] || w == fields[19])
            {
                showQuestion.nextQuestion = 1;
            }
            else if (w == fields[2] || w == fields[3] || w == fields[13] || w == fields[21])
            {
                showQuestion.nextQuestion = 2;
            }
            else if (w == fields[5] || w == fields[7] || w == fields[10] || w == fields[16])
            {
                showQuestion.nextQuestion = 3;
            }
            else if (w == fields[11] || w == fields[14] || w == fields[22] || w == fields[23])
            {
                showQuestion.nextQuestion = 4;
            }
        }

                if (fishka.transform.position == w && check_move1 &&
                    (w != fields[0]
                    && w != fields[4]
                    && w != fields[6]
                    && w != fields[9]
                    && w != fields[12]
                    && w != fields[15]
                    && w != fields[18]
                    && w != fields[20]))
                {
                    check_move1 = false;
            SceneManager.LoadScene(1,LoadSceneMode.Single);
            //Application.LoadLevel("сhooseAnswear");
                }

                if(fishka.transform.position == w && check_move1 &&
                    (w == fields[0]
                    || w == fields[4]
                    || w == fields[6]
                    || w == fields[9]
                    || w == fields[12]
                    || w == fields[15]
                    || w == fields[18]
                    || w == fields[20]))
        {
            check_move1 = false;
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
                
          

            
            
            if (b == fishkaBlack.transform.position) { stop = false; }
            if (fishkaBlack.transform.position != b && !check_move2) { fishkaBlack.transform.position = b;
            Debug.Log("move2_124");
        }
            if (fishkaBlack.transform.position != b && check_move2)
            {
                fishkaBlack.transform.position = Vector3.MoveTowards(fishkaBlack.transform.position, b, step);
            Debug.Log("move2_129");
        }

        if (nextFishka == 2)
        {
            if (b == fields[1] || b == fields[8] || b == fields[17] || b == fields[19])
            {
                showQuestion.nextQuestion = 1;
            }
            else if (b == fields[2] || b == fields[3] || b == fields[13] || b == fields[21])
            {
                showQuestion.nextQuestion = 2;
            }
            else if (b == fields[5] || b == fields[7] || b == fields[10] || b == fields[16])
            {
                showQuestion.nextQuestion = 3;
            }
            else if (b == fields[11] || b == fields[14] || b == fields[22] || b == fields[23])
            {
                showQuestion.nextQuestion = 4;
            }
        }

            if (fishkaBlack.transform.position == b && check_move2 &&
                (b != fields[0]
                && b != fields[4]
                && b != fields[6]
                && b != fields[9]
                && b != fields[12]
                && b != fields[15]
                && b != fields[18]
                && b != fields[20]))
            {
                check_move2 = false;
            SceneManager.LoadScene(1, LoadSceneMode.Single);

            //SceneManager.SetActiveScene(SceneManager.GetSceneByName("chooseAnswear"));
            //Application.LoadLevel("сhooseAnswear");
            }

            if(fishkaBlack.transform.position == b && check_move2 &&
                (b == fields[0]
                
                ||b == fields[4]
                || b == fields[6]
                || b == fields[9]
                || b == fields[12]
                || b == fields[15]
                || b == fields[18]
                || b == fields[20]))
        {
            check_move2 = false;
            SceneManager.LoadScene(3, LoadSceneMode.Single);
        }
            

        
    }
    public static void moveFishka ()
    {
        if (nextFishka == 1)
        {
            if ((rand1 + pos1) > fields.Count)
            {
                w = fields[(rand1 + pos1) - fields.Count];
                //transform.position = v;
                pos1 = (rand1 + pos1) - fields.Count;
                
            }
            else if ((rand1 + pos1) < fields.Count)
            {
                w = fields[rand1 + pos1];
                //transform.position = v;
                pos1 += rand1;
            }
        }

        if (nextFishka == 2)
        {
            if ((rand2 + pos2) > fields.Count)
            {
                b = fields[(rand2 + pos2) - fields.Count];
                //transform.position = v;
                pos2 = (rand2 + pos2) - fields.Count;
            }
            else if ((rand2 + pos2) < fields.Count)
            {
                b = fields[rand2 + pos2];
                //transform.position = v;
                pos2 += rand2;
            }
        }
      
    }
}
