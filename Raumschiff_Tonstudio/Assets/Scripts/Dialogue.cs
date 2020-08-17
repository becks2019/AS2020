using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string name;


    [TextArea(3, 10)] //3 ist Minimum an Zeilen vom Textfeld und 10 ist Maximum
    public string[] sentences;
}
