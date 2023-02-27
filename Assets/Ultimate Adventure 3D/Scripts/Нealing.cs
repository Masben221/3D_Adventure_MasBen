using System.Collections;
using System.Collections.Generic;
using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class Нealing : Pikup
{
    [SerializeField] private int _health;

    [SerializeField] private GameObject impactEffect;
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Destructible _destructible = other.GetComponent<Destructible>();

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            Instantiate(impactEffect, transform.position, Quaternion.identity);

            if (_destructible != null)
            {
                _destructible.ApplyTreatment(_health);
            }
        }
    }
}
