using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Text player;
    // Update is called once per frame
    void Update()
    {
        player.text = "Гравець: "+ move.nextFishka.ToString();
    }
}
