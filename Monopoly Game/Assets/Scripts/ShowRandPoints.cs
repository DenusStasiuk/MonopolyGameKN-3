using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRandPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        p=Random.Range(-2, 2);
        scoreUpdate.points += p;
    }
    public Text points;
    public int p;
    // Update is called once per frame

    void Update()
    {
        points.text = p.ToString() + " add to your points";
    }
}
