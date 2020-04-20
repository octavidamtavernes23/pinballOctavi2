using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    public float force = 100000000000000.0f;
    public float forceRadius = 1.0f;

    void OnCollisionEnter()
    {
        foreach (Collider col in Physics.OverlapSphere (transform.position, forceRadius))
        {
            if(col.GetComponent<Rigidbody>())
            {
                col.GetComponent<Rigidbody>().AddExplosionForce(force,transform.position,forceRadius);
            }
        }
    }
}
