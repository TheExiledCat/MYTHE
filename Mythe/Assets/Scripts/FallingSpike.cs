using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingSpike : MonoBehaviour
{
    [SerializeField]
    GameObject top;
    [SerializeField]
    float climbSpeed, timer;
    float currentTime;
    void Start()
    {
        
    }
    void Drop()
    {
        top.GetComponent<Rigidbody>().isKinematic = false;
    }
    IEnumerator Climb()
    {
        yield return null;
    }
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= timer)
        {
            currentTime = 0;
            Drop();
        }
    }
}
