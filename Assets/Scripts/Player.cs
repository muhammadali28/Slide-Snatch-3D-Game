using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    float speed = 6f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce((transform.forward * speed * Time.deltaTime), ForceMode.Impulse);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce((-transform.forward * speed * Time.deltaTime), ForceMode.Impulse);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce((transform.right * speed * Time.deltaTime), ForceMode.Impulse);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce((-transform.right * speed * Time.deltaTime), ForceMode.Impulse);
        }


    }
}
