using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public Transform pointer;
    public SelectDancer CurrentSelectDancer;

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        //ray.origin = transform.position;
        //ray.direction = transform.forward;
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            pointer.position = hit.point;

            SelectDancer selectDance = hit.collider.gameObject.GetComponent<SelectDancer>();
            if (selectDance)
            {
                if (CurrentSelectDancer && CurrentSelectDancer != selectDance)
                {
                    CurrentSelectDancer.DeactivateAction();
                }
                CurrentSelectDancer = selectDance;
                selectDance.ActivateAction();
            }
            else
            {
                if (CurrentSelectDancer)
                {
                    CurrentSelectDancer.DeactivateAction();
                    CurrentSelectDancer = null;
                }
            }
        }
        else
        {
            if (CurrentSelectDancer)
            {
                CurrentSelectDancer.DeactivateAction();
                CurrentSelectDancer = null;
            }
        }
    }
}
