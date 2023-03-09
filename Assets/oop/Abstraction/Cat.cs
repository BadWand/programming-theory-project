using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
class Cat : Animal
{

    public override void Speak()
    {
        speakText.text = "Derived method from abstract class";
    }




    // Start is called before the first frame update
    void Start()
    {
        Speak();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
