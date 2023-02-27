using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : Pikup
{
    [SerializeField] private GameObject impactEffect;
       
    protected override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);

        Bag _bag = other.GetComponent<Bag>();

        if (_bag != null)
        {
            _bag.AddKey(1);

            Instantiate(impactEffect, transform.position, Quaternion.identity);
        }
    }
}
