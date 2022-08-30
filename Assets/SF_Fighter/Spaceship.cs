using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Spaceship : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 30f;
    public float rotationSpeed = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.drag = 2;
        rb.angularDrag = 2;
        rb.maxAngularVelocity = Mathf.Infinity;
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * rotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * speed;

        rb.AddRelativeForce(0, 0, forwardForce);
        rb.AddRelativeTorque(0, sideForce, 0);
    }
}
