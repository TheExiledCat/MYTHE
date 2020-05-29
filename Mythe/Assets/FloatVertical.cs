using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatVertical : MonoBehaviour
{
 
    public float speed;
    public float freq;
    Vector3 startPos;
    Vector3 tempPos;
    
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        tempPos = startPos;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * freq) * speed;

        transform.position = tempPos;
    }
}
