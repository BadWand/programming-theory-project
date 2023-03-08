using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgr : MonoBehaviour
{
    Vector3 startpos;
    public float regularSpeed;
    float dashSpeed;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
        dashSpeed = regularSpeed * 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.shouldMoveLeft )
        {
            if (!PlayerController.isFaster)
                transform.Translate(Vector3.right * -regularSpeed * Time.deltaTime);
            else
                transform.Translate(Vector3.right * -dashSpeed * Time.deltaTime);

        }



        if (transform.position.x < startpos.x - 50)
        {
            transform.position = startpos;
        }
    }
}
