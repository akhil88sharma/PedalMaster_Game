using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float accSpeed = 10f, revSpeed = 10f, angle = 0f, offset = 0.1f, turnSpeed = 1f;
    public static bool isAccelrating = false , isReversing = false;
    public static bool isTurningLeft = false, isTurningRight = false;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAccelrating)
        {
            rb.AddForce(transform.forward * accSpeed);
        }
        if (isReversing)
        {
            rb.AddForce(-transform.forward * revSpeed);
        }

        
        if (isTurningLeft)
        {
            
            rb.AddTorque(new Vector3(0, -(turnSpeed + angle), 0)*Time.deltaTime);

        }
        else if (isTurningRight)
        {
            
            rb.AddTorque(new Vector3(0, (turnSpeed + angle), 0)*Time.deltaTime);

        }

    }
   
}
