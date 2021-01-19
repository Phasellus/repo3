using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class lab5_zad3 : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 6.6f;
    private bool isRunningUp = true;
    private bool isRunningDown = false;
    private float downPosition;
    private float downPosition2;
    private float upPosition;
    private float upPosition2;
    private float upPosition3;
    private bool changePosition = false;
    void Start()
    {
        upPosition = transform.position.z + distance;
        downPosition = transform.position.z;
        upPosition2 = transform.position.x + distance;
        downPosition2 = transform.position.x;
        upPosition3 = upPosition + distance;

    }

    void Update()
    {
        if (isRunningUp && transform.position.z >= upPosition3)
        {
            isRunning = false;
        }
        else if (isRunningDown && transform.position.z <= downPosition)
        {
            isRunning = false;
        }
        if (transform.position.z >= upPosition)
        {
            changePosition = true;
        }
        if (transform.position.x >= upPosition2)
        {
            changePosition = false;
        }
        if (isRunningDown && transform.position.z <= upPosition)
        {
            changePosition = true;
        }
        if (isRunningDown && transform.position.x <= downPosition2)
        {
            changePosition = false ;
        }
        if (isRunning)
        {
            if(changePosition) {
                Vector3 move = transform.right * elevatorSpeed * Time.deltaTime;
                transform.Translate(move);
            }
            else
            {
                Vector3 move = transform.forward * elevatorSpeed * Time.deltaTime;
                transform.Translate(move);
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
            if (transform.position.z >= upPosition3)
            {
                isRunningDown = true;
                isRunningUp = false;
                elevatorSpeed = -elevatorSpeed;
            }
            else if (transform.position.z <= downPosition)
            {
                isRunningUp = true;
                isRunningDown = false;
                elevatorSpeed = Mathf.Abs(elevatorSpeed);
            }
            isRunning = true;
        }
    }
}