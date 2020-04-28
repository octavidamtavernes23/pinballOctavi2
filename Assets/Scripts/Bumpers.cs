using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    public float force = 10000f;
    public float forceRadius = 2f;
    public float increment=1;

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
