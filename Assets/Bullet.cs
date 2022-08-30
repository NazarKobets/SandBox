using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().useGravity = true;

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
            if (collision.collider.GetComponent<EnemyHead>())
            {
                Debug.Log("œ¿” Ã»Õ”— “–» ﬁ’”");
            }
        }

        Douglas douglas = collision.gameObject.GetComponentInParent<Douglas>(); 
        if (douglas)
        {
            douglas.MakePhysical();
        }
    }
}
