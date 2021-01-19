using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class lab5_zad2 : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 20f;
    private bool isRunningDown = true;
    private float downPosition;
    private float upPosition;
    public Transform door2;
    void Start()
    {
        upPosition = transform.position.z + distance;
        downPosition = transform.position.z;
    }

    void Update()
    {
        
        if (isRunningDown && transform.position.z >= upPosition)
        {
            isRunning = false;
        }
        else if (!isRunningDown && transform.position.z < downPosition)
        {
            isRunning = false;
        }
        if (isRunning)
        {
            Vector3 move = transform.forward * elevatorSpeed * Time.deltaTime;
            if (isRunningDown)
            {
                transform.Translate(move);
                door2.Translate(-move);
            }
            else
            {
                transform.Translate(-move);
                door2.Translate(move);
            }

        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRunningDown = true;
            if (transform.position.z < upPosition)
            {
                isRunning = true;
            }
            if (transform.position.z >=  upPosition)
            {
                isRunning = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isRunning = true;
            isRunningDown = false;
        }
    }
}