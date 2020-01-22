using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Object button;
    void OnMouseDown()
    {
        transform.localScale = new Vector3(1.693f, 2.296f, 1f);
    }
    void onMouseUp()
    {
        transform.localScale = new Vector3(1.623f, 2.226f, 1f);
    }


    void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(0);
    }
}
