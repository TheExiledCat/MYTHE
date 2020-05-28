using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggers : MonoBehaviour
{
    DialogueCycle dCycle;
    public string key;

    void Start()
    {
        dCycle = GameObject.FindGameObjectWithTag("Player").GetComponent<DialogueCycle>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            dCycle.Cycle(key);
        }
        print(col);
    }
}
