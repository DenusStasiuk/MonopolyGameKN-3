using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayer : MonoBehaviour
{
    void OnMouseDown()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x + 0.3f, t.y + 0.3f, 1f);
    }
    void OnMouseUp()
    {
        var t = transform.localScale;
        transform.localScale = new Vector3(t.x - 0.3f, t.y - 0.3f, 1f);
    }

    void OnMouseUpAsButton()
    {
        if (move.nextFishka == 1) { move.nextFishka = 2; }
        else if (move.nextFishka == 2) { move.nextFishka = 1; }
        else { move.nextFishka = 1; }
    }
}
