using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douglas : MonoBehaviour
{
    public Animator anim;
    public Rigidbody[] allRigidbody; // == 10 // [0] [1] ... [9]

    void Start()
    {
        for (int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = true;
        }

        //то что ниже не пишите
        /*        allRigidbody[0].isKinematic = true;
                allRigidbody[1].isKinematic = true;
                allRigidbody[2].isKinematic = true;
                allRigidbody[3].isKinematic = true;
                allRigidbody[4].isKinematic = true;
                allRigidbody[5].isKinematic = true;
                allRigidbody[6].isKinematic = true;
                allRigidbody[7].isKinematic = true;
                allRigidbody[8].isKinematic = true;
                allRigidbody[9].isKinematic = true;
                allRigidbody[10].isKinematic = true;
                allRigidbody[11].isKinematic = true;*/
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    public void MakePhysical()
    {
        anim.enabled = false;

        for (int i = 0; i < allRigidbody.Length; i++)
        {
            allRigidbody[i].isKinematic = false;
        }
    }
}