using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : ShapeScript
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        isSphere = true;
    }

    public override void SayName()
    {
        base.SayName();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
