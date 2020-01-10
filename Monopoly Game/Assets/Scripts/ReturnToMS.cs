using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMS : MonoBehaviour
{
    void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
