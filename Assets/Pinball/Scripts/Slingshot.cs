using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour {
    public float forceMultiplier = 1.0f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
        Vector3 vr = collision.relativeVelocity;

        rb.AddForce(-vr.normalized * forceMultiplier);
    }
}
