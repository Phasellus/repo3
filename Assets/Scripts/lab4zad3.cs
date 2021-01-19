using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class lab4zad3 : MonoBehaviour
{
    public Transform player;
    float mouseXMove;
    float mouseYMove;
    float obrot;

    public float sensitivity = 200f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        obrot += mouseYMove;
        player.Rotate(Vector3.up * mouseXMove);

        if(obrot < 45 && obrot > -45)
        {
            transform.Rotate(new Vector3(-mouseYMove, 0f, 0f), Space.Self);
        }

    }
}