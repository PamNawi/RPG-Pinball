using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnParticlesOn : MonoBehaviour {

    public ParticleSystem ps;

    public void Start()
    {
        if(ps == null)
            ps = GetComponentInChildren<ParticleSystem>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        ps.Play();
    }
}
