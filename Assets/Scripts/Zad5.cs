using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Zad5 : MonoBehaviour
{
    public GameObject block;
    public int howMany = 10;

    void Start()
    {
        for (int i = 0; i < howMany; i++)
        {
            int x = Random.Range(-4, 5);
            int z = Random.Range(-4, 5);
            Instantiate(block, new Vector3(x, 1 , z), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
