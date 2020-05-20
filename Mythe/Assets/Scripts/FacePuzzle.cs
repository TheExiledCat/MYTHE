using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacePuzzle : MonoBehaviour
{
    public Gate gate;

    public int faceOrder = 1;
    private bool isHit = false;

    private bool complete = false;
    public LayerMask Totem;

    public AudioSource Happy;
    public AudioSource Shocked;
    public AudioSource Sad;
    public AudioSource Angry;
    public AudioSource Fail;

    void Update()
    {
        Completed();
    }

    void Completed()
    {
        if (complete)
        {
            print("done");
            gate.Open();
            complete = false;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        
        isHit = true;
        if (col.gameObject.tag=="Happy"|| col.gameObject.tag == "Sad" || col.gameObject.tag == "Shocked" || col.gameObject.tag == "Angry")
        {
            Debug.Log(col.gameObject.tag);
            if (isHit && faceOrder == 1 && col.gameObject.tag == "Happy")
            {
                faceOrder++;
                Happy.Play(0);
                isHit = false;
            }

            else if (isHit && faceOrder == 2 && col.gameObject.tag == "Shocked")
            {
                faceOrder++;
                Shocked.Play(0);
                isHit = false;
            }

            else if (isHit && faceOrder == 3 && col.gameObject.tag == "Sad")
            {
                faceOrder++;
                Sad.Play(0);
                isHit = false;
            }

            else if (isHit && faceOrder == 4 && col.gameObject.tag == "Angry")
            {
                complete = true;
                Angry.Play(0);
                isHit = false;
            }

            else
            {
                faceOrder = 1;
                Fail.Play(0);
            }

        }

    }
}
