﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMS : MonoBehaviour
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
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
