
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    List<Vector3> fields = new List<Vector3>();
    public static int rand=0;
    void Start()
    {
        
        fields.Add(new Vector3(61.7f, 23.5f));
        fields.Add(new Vector3(60.4f, 23.5f));
        fields.Add(new Vector3(58.8f, 23.5f));
        fields.Add(new Vector3(57.2f, 23.5f));
        fields.Add(new Vector3(56.2f, 23.5f));
        fields.Add(new Vector3(55.0f, 23.5f));
        
    }
    void Update()
    {

        Vector3 v = fields[rand];
        transform.position = v;
        
    }
}
