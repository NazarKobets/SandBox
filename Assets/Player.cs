using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float torqueValue = 5;
    public Transform cameraCenter;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 500f;
    }
    
    void FixedUpdate()
    {
        rb.AddTorque(cameraCenter.right * Input.GetAxis("Vertical") * torqueValue);
        rb.AddTorque(-cameraCenter.forward * Input.GetAxis("Horizontal") * torqueValue);
    }
}
