using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(transform.forward * 100);
        }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 5);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * 3);
        }
         
        if (Input.GetKey(KeyCode.A))
        {
            //rb.MoveRotation(Quaternion.Euler(0, 3, 0));
            rb.rotation = (Quaternion.Euler(0, 1+ rb.rotation.eulerAngles.y, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(transform.forward * -100);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -3);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //rb.MoveRotation(Quaternion.Euler(0, 3, 0));
            rb.rotation = (Quaternion.Euler(0, -1 + rb.rotation.eulerAngles.y, 0));
        }
    }
}
