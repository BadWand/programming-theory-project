using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EncapScript
{
    private string name_ = " - - ";

    public EncapScript(string objname)
    {
        name_ = objname;
    }
    public string getName
    {
        get { return name_; }
        set { name_ = value; }
    }
}


