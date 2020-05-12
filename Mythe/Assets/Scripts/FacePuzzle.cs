using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePuzzle : MonoBehaviour
{
    public int faceOrder = 1;
    private bool isHit = false;

    private bool complete = false;

    void OnCollisionEnter(Collision col)
    {
        isHit = true;

        if (isHit && faceOrder == 1 && col.gameObject.tag == "Happy")
        {
            faceOrder++;
            isHit = false;
        }

        else if (isHit && faceOrder == 2 && col.gameObject.tag == "Shocked")
        {
            faceOrder++;
            isHit = false;
        }

        else if (isHit && faceOrder == 3 && col.gameObject.tag == "Sad")
        {
            faceOrder++;
            isHit = false;
        }

        else if (isHit && faceOrder == 4 && col.gameObject.tag == "Angry")
        {
            complete = true;
            isHit = false;
        }

        else
        {
            faceOrder = 1;
        }
        
    }
}
