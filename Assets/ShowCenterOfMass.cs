using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCenterOfMass : MonoBehaviour
{
    public Transform centerOfMass;

    private void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = Vector3.Scale(centerOfMass.localPosition, transform.localScale);

        GetComponent<Rigidbody>().WakeUp();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.2f);
    }
}
