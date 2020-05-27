using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    public AudioSource Gatesound;
    public void Open()
    {

        StartCoroutine(MoveGate());
    }
    IEnumerator MoveGate()
    {
        for (int i = 0; i < 60; i++)
        {
            Gatesound.Play(0);
            transform.position += Vector3.down * (transform.localScale.y / 2);
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
}