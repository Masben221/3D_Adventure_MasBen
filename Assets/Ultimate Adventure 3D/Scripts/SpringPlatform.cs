using System.Collections;
using System.Collections.Generic;
using SimpleFPS;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SpringPlatform : MonoBehaviour
{
    [SerializeField] private int _jumpForce;

    private AudioSource _audio;    

    private float previusJumpForce;

    private void Start()
    {
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            previusJumpForce = fps.m_JumpSpeed;

            fps.m_JumpSpeed += _jumpForce;
            //fps.m_Jump = true;

            _audio.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed = previusJumpForce; 
        }
    }
}
