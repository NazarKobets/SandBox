using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class LerpAll : MonoBehaviour
{
    public Transform t1;
    public Transform t2;

    public Material m1;
    public Material m2;

    public Material m3;

    [Range(0, 1)]
    public float value;

    void Update()
    {
        transform.position = Vector3.Lerp(t1.position, t2.position, value);
        transform.localScale = Vector3.Lerp(t1.localScale, t2.localScale, value);
        transform.rotation = Quaternion.Lerp(t1.rotation, t2.rotation, value);
        m3.color = Color.Lerp(m1.color, m2.color, value);
    }
}
