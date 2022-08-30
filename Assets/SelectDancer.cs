using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectDancer : MonoBehaviour
{
    Animator anim;
    Light mylight;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mylight = GetComponentInChildren<Light>();
        DeactivateAction();
    }

 public void ActivateAction()
    {
        anim.enabled = true;
        mylight.enabled = true;
    }

    public void DeactivateAction()
    {
        anim.enabled = false;
        mylight.enabled = false;
    }
}
