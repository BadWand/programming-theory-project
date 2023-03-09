using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Obstacle : MonoBehaviour
{

    public float mass;
    public Text textObj;
    public string message;
    public float jumpForce;

    public Rigidbody rb;
    
    public virtual void DisplayMessage()
    {
        textObj.text = "I am an object";
    }
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
        InvokeRepeating("Jump", 0.5f, 2f);
    }

    void Jump()
    {
        print("is jumping with " + jumpForce + " force");
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
