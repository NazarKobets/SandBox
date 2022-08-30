using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyArray : MonoBehaviour
{

    public GameObject[] objectsArray;

    public Light[] allLights;

    public Rigidbody[] AllRigidbodies;

    void Start()
    {
        /*objectsArray[0].name = "Element 1";
        objectsArray[0].GetComponent<Renderer>().material.color = Color.yellow;
        objectsArray[1].GetComponent<Renderer>().material.color = Color.yellow;*/
        for (int i = 0; i < objectsArray.Length; i++) // i 0, 1, 2, 3 
        { 
            objectsArray[i].GetComponent<Renderer>().material.color = Color.yellow;
            objectsArray[i].AddComponent<Rigidbody>();
        }

        AllRigidbodies = FindObjectsOfType<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0)) {
            for (int i = 0; i < objectsArray.Length; i++)
            {
                objectsArray[i].GetComponent<Rigidbody>().AddForce(0, 10, 0);
            }

            for (int i = 0; i < allLights.Length; i++)
            {
                allLights[i].color = Color.red;
            }
        }
        else
        {
            for (int i = 0; i < allLights.Length; i++)
            {
                allLights[i].color = Color.white;
            }
        }
    }
}
