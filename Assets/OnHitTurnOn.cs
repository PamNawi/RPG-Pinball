using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitTurnOn : MonoBehaviour {

    Light lamp;

    public void Start()
    {
        lamp = GetComponentInChildren<Light>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        lamp.enabled = true;
    }
}
