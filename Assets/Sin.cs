using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{
    public float frequency = 5;
    public float amplitude = 0.5f;
    public float offset = 0.5f;

    void Update()
    {
        transform.localScale = Vector3.one * (Mathf.Sin(Time.time * frequency * 2 * Mathf.PI) * amplitude + offset);
    }
}
