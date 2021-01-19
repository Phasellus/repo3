using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float force = 1.0f;
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
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(10.0f, 1.0f, -10.0f);
            transform.Rotate(0, 90, 0, Space.Self);
            rb.AddForce(Vector3.forward * force, ForceMode.Impulse);
            //rb.AddForce(Vector3.right, ForceMode.Impulse);

        }
        if (rb.worldCenterOfMass.z > 0)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(10.0f, 1.0f, 0.0f);
            transform.Rotate(0, -90, 0, Space.Self);
            rb.AddForce(Vector3.right * -force, ForceMode.Impulse);

        }
        if (rb.worldCenterOfMass.x < 0)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(0.0f, 1.0f, 0.0f);
            transform.Rotate(0, 90, 0, Space.Self);
            rb.AddForce(Vector3.forward * -force, ForceMode.Impulse);
          
        }
        if (rb.worldCenterOfMass.z < -10)
        {
            rb.velocity = new Vector3(0, 0, 0);
            transform.position = new Vector3(0.0f, 1.0f, -10.0f);
            transform.Rotate(0, -90, 0, Space.Self);
            rb.AddForce(Vector3.right * force, ForceMode.Impulse);

        }

    }

}