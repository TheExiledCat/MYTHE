using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueDisplay : MonoBehaviour
{
    public TextMeshProUGUI txt;

    public void ShowDialogue(string text)
    {
        StopDialogue();
        txt.gameObject.SetActive(true);
        txt.text = text;
        Invoke("StopDialogue", 4f);

    }

    void StopDialogue()
    {
        txt.gameObject.SetActive(false);
    }
}
