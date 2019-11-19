
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    List<Vector3> fields = new List<Vector3>();
    
    void Start()
    {
        fields.Add(new Vector3(-0.04f, -3.93f));
        fields.Add(new Vector3(-1.16f, -3.93f));
        fields.Add(new Vector3(-2.64f, -3.93f));
        fields.Add(new Vector3(-4.06f, -3.93f));
        fields.Add(new Vector3(-5.33f, -3.93f));
        fields.Add(new Vector3(-6.5f, -3.93f));
    }
    void Update()
    {

        Vector3 v = fields[Random.Range(0,5)];
        transform.position = v;
        
    }
}
