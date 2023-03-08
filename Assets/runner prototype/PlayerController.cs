using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce = 10f;
    public float gravity;

    public bool isGrounded;
    public bool doubleJump;
    public static bool shouldMoveLeft;
    public static bool isFaster;
    Animator anim;
    GameObject model;
    // Start is called before the first frame update
    void Start()
    {
        model = GameObject.Find("playerModel");
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;
        shouldMoveLeft = true;
        anim = GetComponentInChildren<Animator>();

        anim.SetFloat("Speed_f", .3f);
        anim.SetBool("Static_b", true);
        doubleJump = false;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();

        model.transform.localPosition = new Vector3(0, model.transform.localPosition.y, model.transform.localPosition.z);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded || doubleJump)
            {

                anim.SetBool("Jump_b", true);

                print("jump");
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                if ((isGrounded))
                {

                    print("regular jump");
                    isGrounded = false;


                }
                else if (doubleJump)
                {
                    doubleJump = false;
                }
            }
            



        }
        Dash();
    }

    void Dash()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isFaster = true;
            anim.speed = 1.5f;
        }
        else
        {

            anim.speed = 1.0f;
            isFaster = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            anim.SetBool("Jump_b", false);

            isGrounded = true;
            doubleJump = false;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            print("obstacle");
            shouldMoveLeft = false;
            this.gameObject.SetActive(false);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            doubleJump = true;
        }
    }


}
