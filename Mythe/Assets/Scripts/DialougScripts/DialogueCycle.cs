using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCycle : MonoBehaviour
{
    Dialogues dia = new Dialogues();
    public DialogueDisplay dDisplay;

    [SerializeField]
    string currentText;

    public void Cycle(string key)
    {
        if (dia.dialogue.ContainsKey(key))
        {
            currentText = dia.dialogue[key];
            dDisplay.ShowDialogue(currentText);
        }
    }
}
