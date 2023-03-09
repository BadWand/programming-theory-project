using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Encapsulation
{

    class Program : MonoBehaviour
    {
        EncapScript encap = new EncapScript("Encapsulation Demonstration");
        public Text text_;
        private void Start()
        {
            text_.text = encap.getName.ToString();
        }

    }

    //class Obj
    //{
    //    private string name_ = " - - ";

    //    public Obj(string objname)
    //    {
    //        name_ = objname;
    //    }
    //    public string getName
    //    {
    //        get { return name_; }
    //        set { name_ = value; }
    //    }

    //}
}

