using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class DamageZone : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _damageRate;

    private Destructible _destructible;
    private float _timer;

    private AudioSource _audio;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (_destructible == null) return;

            _timer += Time.deltaTime;

        if (_timer >= _damageRate)
        {
            if (_destructible != null)
            {
                _destructible.ApplyDamage(_damage);
            }
            
            _timer = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _destructible = other.GetComponent<Destructible>();

        _audio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Destructible>() == _destructible)
        _destructible = null;
    }
}
