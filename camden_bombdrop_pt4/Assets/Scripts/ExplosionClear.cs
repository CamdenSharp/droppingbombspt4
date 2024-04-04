using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionClear : MonoBehaviour
{
    private ParticleSystem particleSmoke;

    public void Awake()
    {
        particleSmoke = gameObject.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!particleSmoke.IsAlive())
        {
            Destroy(gameObject);
        }
    }
}