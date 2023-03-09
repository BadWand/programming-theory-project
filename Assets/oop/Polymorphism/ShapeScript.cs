using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShapeScript : MonoBehaviour
{
    public bool isSphere;
    public Text nameText;
    // Start is called before the first frame update
    public virtual void Start()
    {
        SayName();
    }

    public virtual void SayName()
    {
        nameText.text = "Is Sphere: " + isSphere;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
