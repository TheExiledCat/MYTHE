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
        dialogue.Add("Tutorial", "Welcome Quetzalcoatl\nHold W/S to go back and forward\nUse A/D to slither");
        dialogue.Add("FacePuzzle", "An old Aztec System\nI need to touch the stones in order\nThe Crystals and pages guide me");
        dialogue.Add("BlockPuzzle", "Ah a pressure plate\nI bet I can pick up those boxes with Mouse 0\nand move them with the scrollwheel");
        dialogue.Add("Traps","Oh No!\nHope I dont hit one");
        dialogue.Add("Finish", "I Made it!");
    }

}
