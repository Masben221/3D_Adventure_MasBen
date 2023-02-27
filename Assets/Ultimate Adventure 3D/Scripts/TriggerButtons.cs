using SimpleFPS;
using UnityEngine;
using UnityEngine.Events;

public class TriggerButtons : MonoBehaviour
{
    private bool _leftButton = false;
    private bool _rightButton = false;

    [SerializeField] protected UnityEvent _Enter;
    [SerializeField] protected UnityEvent _Exit;

    private void OnTriggerEnter(Collider other)
    {
        if (_leftButton == false || _rightButton == false) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            _Enter.Invoke();
            _leftButton = false;
            _rightButton = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_leftButton == false || _rightButton == false) return;

        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            _Exit.Invoke();
            _leftButton = false;
            _rightButton = false;
        }
    }

    public void SetLeftButton()
    {
        _leftButton = true;
    }

    public void SetRightButton()
    {
        _rightButton = true;
    }

    public bool GetLeftButton()
    {
        return _leftButton;
    }

    public bool GetRightButton()
    {
        return _rightButton;
    }
}
