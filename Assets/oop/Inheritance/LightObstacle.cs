using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LightObstacle : Obstacle
{
    

    public override void DisplayMessage()
    {
        base.DisplayMessage();
        textObj.text = message + " mass: " + mass;

    }
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        print("Light inherited start");
        DisplayMessage();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
