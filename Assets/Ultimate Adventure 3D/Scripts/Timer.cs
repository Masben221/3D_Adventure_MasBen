using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    private float _time;
    [SerializeField] private Breaker _breaker;
    [SerializeField] private float _limitTime;
    [SerializeField] private UnityEvent _eventOff;

    private void Update()
    {
        if (_time < _limitTime)
        {
            _time += Time.deltaTime;
        }

        if (_time > _limitTime)
        {
            _eventOff.Invoke();
            _time = 0;
        }
    }
}
