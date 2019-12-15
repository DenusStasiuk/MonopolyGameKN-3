using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(0);
    }
}
