using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueDisplay : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public GameObject snakeUI;
    public void ShowDialogue(string text)
    {
        StopDialogue();
        snakeUI.gameObject.SetActive(true);
        txt.text = text;
        Invoke("StopDialogue", 4f);

    }

    void StopDialogue()
    {
        snakeUI.gameObject.SetActive(false);

    }
}
