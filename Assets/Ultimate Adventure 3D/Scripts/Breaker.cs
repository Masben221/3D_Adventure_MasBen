using System.Collections;
using System.Collections.Generic;
using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class Breaker : MonoBehaviour
{
    [SerializeField] private UnityEvent _eventOn;
    [SerializeField] private UnityEvent _eventOff;

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            _eventOn.Invoke();
        }
    }
    public void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            _eventOff.Invoke();
        }
    }
    
}
