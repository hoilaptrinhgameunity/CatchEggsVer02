using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backup_BaseFruitClass
{

    private string fruitClassName;
    private string fruitClassDescription;

    private string dirFileSound;

    public string FruitClassName
    {
        get { return fruitClassName; }
        set { fruitClassName = value; }
    }
    public string FruitClassDescription
    {
        get { return fruitClassDescription; }
        set { fruitClassDescription = value; }
    }
    public string DirFileSound
    {
        get { return dirFileSound; }
        set { dirFileSound = value; }
    }
}
