using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class lab4zad1 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public float delay = 3.0f;
    int objectCounter = 0;
    // obiekt do generowania
    public GameObject block;
    public int howMuch = 10;
    public GameObject plane;
    public List<Material> materials;

    void Start()
    {
        // w momecie uruchomienia generuje 10 kostek w losowych miejscach
        List<int> pozycje_x = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(howMuch));
        List<int> pozycje_z = new List<int>(Enumerable.Range(0, 20).OrderBy(x => Guid.NewGuid()).Take(howMuch));

        for (int i = 0; i < howMuch; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 5, pozycje_z[i]));
            //this.GetComponent<MeshRenderer>().material = materials[i];


        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        // uruchamiamy coroutine
        StartCoroutine(GenerujObiekt());
    }

    void Update()
    {

    }

    IEnumerator GenerujObiekt()
    {
        Debug.Log("wywołano coroutine");
        foreach (Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);

            yield return new WaitForSeconds(this.delay);

        }
        // zatrzymujemy coroutine
        StopCoroutine(GenerujObiekt());
        

    }

}