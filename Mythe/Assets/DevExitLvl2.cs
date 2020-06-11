using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DevExitLvl2 : MonoBehaviour
{
    [SerializeField]
    Transform[] exits;
    int input;
    // Start is called before the first frame update
    GameObject[] slices;
    Vector3[] startPos;
    GameObject head;
    void Start()
    {
        slices = GameObject.FindGameObjectsWithTag("Joints");
        startPos = new Vector3[slices.Length+1];
        head = GameObject.FindGameObjectWithTag("Player");
        int i = 0;
        foreach(GameObject g in slices)
        {
            startPos[i] = g.transform.localPosition;
            i++;
        }
        startPos[slices.Length] = head.transform.localPosition;
    }
    // Update is called once per frame
    void Update()
    {
        if( int.TryParse(Input.inputString,out input))
        {
            print(input);
            if (input > 0 && input <= exits.Length && exits.Length > 0)
            {
                Teleport();
            }
        }
        
       
        
    }
    void Teleport()
    {
        int i = 0;
        foreach(GameObject g in slices)
        {
            g.transform.localPosition = startPos[i];
            i++;
        }
        head.transform.localPosition = startPos[slices.Length];
        transform.position = exits[input - 1].position;
    }
}
