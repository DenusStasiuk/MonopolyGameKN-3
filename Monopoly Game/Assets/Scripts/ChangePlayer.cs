using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
        if (move.nextFishka == 1) { move.nextFishka = 2; }
        else if (move.nextFishka == 2) { move.nextFishka = 1; }
        else { move.nextFishka = 1; }
    }
}
