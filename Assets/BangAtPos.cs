using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPos : MonoBehaviour
{
    public Rigidbody targetRigibody;
    public float forceValue = 200f;
    public ParticleSystem ps;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            targetRigibody.AddForceAtPosition(transform.up * forceValue, transform.position);
            ps.Play();
        }
    }
}
