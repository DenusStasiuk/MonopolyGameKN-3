using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    void OnMouseDown()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x + 0.2f, t.y + 0.2f, 1f);
    }
    void OnMouseUp()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x - 0.2f, t.y - 0.2f, 1f);
    }

    public Sprite layer;
    public static int randNum;
    void OnMouseUpAsButton()
    {
        // if (move.nextFishka == 1) { move.nextFishka = 2; }
        //else if (move.nextFishka == 2) { move.nextFishka = 1; }
        //else { move.nextFishka = 1; }
        if (move.nextFishka == 1) {
        move.rand1 = Random.Range(1, 6);
        move.check_move1 = true;

        move.moveFishka();
            //move.nextFishka =2;
         }
        if (move.nextFishka == 2)
        {
            move.rand2 = Random.Range(1, 6);
            move.check_move2 = true;
            move.moveFishka();
            //move.nextFishka = 1;
            
        }
        
    } 
}
