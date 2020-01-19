using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowRandomNumbers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text randNum;
    // Update is called once per frame
    void Update()
    {
        if (move.nextFishka == 1)
        {
            randNum.text = "Значення на ігровому кубику: " + move.rand1.ToString();
        }
        else if (move.nextFishka == 2)
        {
            randNum.text = "Значення на ігровому кубику: " + move.rand2.ToString();
        }
        //randNum.text ="Значення на ігровому кубику: " + move.rand1.ToString() +"\n"+move.rand2.ToString();
    }
}
