using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject messageBox;
    [SerializeField] private int amountKeyActivate;

    [SerializeField] private UnityEvent Enter;

    private bool isActive = false;

    protected void OnTriggerEnter(Collider other)
    {
        if (isActive == true) return;

        Bag _bag = other.GetComponent<Bag>();

        if (_bag != null)
        {
            if (_bag.DrawKey(amountKeyActivate) == true)
            {
                Enter.Invoke();
                isActive = true;
            }
            else
            {
                messageBox.SetActive(true);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        messageBox.SetActive(false);
    }
}
