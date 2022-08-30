using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineFinder : MonoBehaviour
{
    public float distance;
    public LayerMask layerMask;

    void Start()
    {

    }


    void Update()
    {
        Ray ray = new Ray(transform.position, -Vector3.up);

        if (Physics.Raycast(ray, distance, layerMask))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.white;

        }
    }
}
