using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Sprite layer;
    void OnMouseUpAsButton()
    {
        move.rand = Random.Range(1, 6);
        move.moveFishka();
        move.check_move = true;
    } 
}
