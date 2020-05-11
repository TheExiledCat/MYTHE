using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    private bool hHit = false;
    private bool aHit = false;
    private bool sHit = false;
    private bool shHit = false;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Happy")
        {
            hHit = true;
            Debug.Log("Green " + hHit);
        }

        else if (col.gameObject.tag == "Angry")
        {
            aHit = true;
            Debug.Log("Red " + aHit);
        }

        else if (col.gameObject.tag == "Sad")
        {
            sHit = true;
            Debug.Log("Blue " + sHit);
        }

        else if (col.gameObject.tag == "Shocked")
        {
            shHit = true;
            Debug.Log("Yellow " + shHit);
        }
    }
}
