using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseLetersClass
{
    private string lettersClassName;
    private string lettersClassDescription;
    private string mixerName;
    private string dirFileSound;

    public string LettersClassName
    {
        get { return lettersClassName; }
        set { lettersClassName = value; }
    }
    public string LettersClassDescription
    {
        get { return lettersClassDescription; }
        set { lettersClassDescription = value; }
    }
    public string DirFileSound
    {
        get { return dirFileSound; }
        set { dirFileSound = value; }
    }
    public string MixerName
    {
        get { return mixerName; }
        set { mixerName = value; }
    }
}
