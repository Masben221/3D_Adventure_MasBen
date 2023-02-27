using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destructible : MonoBehaviour
{
    [SerializeField] private int _maxHitPoints;

    public UnityEvent Die;
    public UnityEvent ChangeHitPoints;

    private int _hitPoints;

    private void Start()
    {
        _hitPoints = _maxHitPoints;

        ChangeHitPoints.Invoke();
    }
    public void ApplyDamage(int damage)
    {
        _hitPoints -= damage;

        ChangeHitPoints.Invoke();

        if (_hitPoints <=0)
        {
            Kill();
        }

    }
    public void Kill()
    {
        _hitPoints = 0;

        ChangeHitPoints.Invoke();

        Die.Invoke();
    }
    
    public void ApplyTreatment(int _health)
        {
            _hitPoints += _health;            

            if (_hitPoints >= _maxHitPoints)
            {
                _hitPoints = _maxHitPoints;
            }
            ChangeHitPoints.Invoke();
    }
    public int GetHitPoints()
    {
        return _hitPoints;
    }
    public int GetMaxHitPoints()
    {
        return _maxHitPoints;
    }
}
