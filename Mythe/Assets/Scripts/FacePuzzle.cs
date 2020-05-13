using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePuzzle : MonoBehaviour
{
    public int faceOrder = 4;
    public GameObject[] selectorArr;

    void Start()
    {
        selectorArr = new GameObject[faceOrder];

        for (int i = 0; i < faceOrder; i++)
        {

        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("oof");
        }
    }
}
