using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRandPoints : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        p = Random.Range(-2, 2);
        if (move.nextFishka == 1)
        {
            scoreUpdate.wPoints += p;
        }
        else if (move.nextFishka == 2)
        {
            scoreUpdate.bPoints += p;
        }
    }
    public Text points;
    public int p;
    // Update is called once per frame

    void Update()
    {
        points.text ="До вашого рахунку додано "+ p.ToString() +" бал(балів)";
    }
}
