using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueDisplay : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public GameObject snek;
    public float t;
    public void ShowDialogue(string text)
    {
        StopDialogue();
        snek.gameObject.SetActive(true);
        txt.text = text;
        Invoke("StopDialogue", t);

    }

    void StopDialogue()
    {
        snek.gameObject.SetActive(false);
        
    }
}
