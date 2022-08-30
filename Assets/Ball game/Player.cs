using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody rb;
    public float torqueValue = 5;
    public Transform cameraCenter;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 5;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddTorque(cameraCenter.right * Input.GetAxis("Vertical") * torqueValue);
        rb.AddTorque(-cameraCenter.forward * Input.GetAxis("Horizontal") * torqueValue);
    }
}
