using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPositioner : MonoBehaviour
{
   
     public Transform[] points;
    [SerializeField]
    private LineRenderer lr;
    int length;
    bool even;
    void Start()
    {
        
        length = points.Length;
        if (length == 0)
        {
            enabled = false;
        }
        if (length % 2 == 0)//check if its an even number or not
        {
            lr.positionCount = length;
            even = true;
        }else
        {
            lr.positionCount = length + 1;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < length; i++)
        {
           
            
            
                lr.SetPosition(i, points[i].position);
            
        }
        if (!even)
        {
            lr.SetPosition(length, points[0].position);
        }
        
    }
}
