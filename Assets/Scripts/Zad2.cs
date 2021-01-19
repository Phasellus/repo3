using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float force = 10.0f;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * force, ForceMode.Impulse);
    }

    void FixedUpdate()
    {
        if (rb.worldCenterOfMass.x > 10)
        {

            rb.AddForce(Vector3.right * -force, ForceMode.Impulse);

        }
        if (rb.worldCenterOfMass.x < 0)
        {

            rb.velocity = Vector3.zero;
            transform.position = new Vector3(0.0f, 3.0f, 0.0f);

        }

    }

}
