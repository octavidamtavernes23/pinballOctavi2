using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers_pilota : MonoBehaviour
{
     public float force = 10000f;
    public float forceRadius = 1f;
    public float increment=1;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.gameObject.CompareTag("bumpers"))
        {
            Debug.Log ("ha contactat bumper");
            foreach (Collider col in Physics.OverlapSphere (transform.position, forceRadius))
        {
            Debug.Log ("ha entrat al bucle foreach " + col + "vegades.");            
            if(col.GetComponent<Rigidbody>())
            {
                Debug.Log ("ha imprimit forÇa " + force + ".");
                col.GetComponent<Rigidbody>().AddExplosionForce(force,transform.position,forceRadius);
               //transform.Translate(new Vector3(1f/,0f,0f*) * force * Time.deltaTime);

            }
        }

        }
    }
}
