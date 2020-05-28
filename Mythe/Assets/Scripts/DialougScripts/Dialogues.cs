using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class Dialogues
{
    public Dictionary<string, string> dialogue = new Dictionary<string, string>();

    public Dialogues()
    {
        dialogue.Add("Tutorial", "Welcome Quetzalcoatl");
        dialogue.Add("Controls", "");
        dialogue.Add("FacePuzzle", "");
        dialogue.Add("BlockPuzzle", "");
        dialogue.Add("Traps", "");
        dialogue.Add("Finsih", "");
    }

}
