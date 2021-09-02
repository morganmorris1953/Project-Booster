using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float mainThrust = 1000.0f;
    float rotateSpeed = 50f;

    // float smooth = 5.0f;
    // float tiltAngle = -30.0f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }

    void ProcessThrust()
    
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
//   00          rb.AddRelativeForce(0, yMovement, 0);
            //another way to write this:
            rb.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }
    }

    void ProcessRotation()
    {
        // 
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(rotateSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(-rotateSpeed);
        }

        // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        // Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);
        // transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
    }

    void ApplyRotation(float rotationThisFrame) 
    {
        rb.freezeRotation = true;
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.freezeRotation = false;
    }
}
