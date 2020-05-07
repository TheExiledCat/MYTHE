using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTestScript : MonoBehaviour
{
    private int hp = 5;
    private int dmg = 1;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "TrapBox")
        {
            hp = hp - dmg;
            Debug.Log(hp);
        }
    }
}
