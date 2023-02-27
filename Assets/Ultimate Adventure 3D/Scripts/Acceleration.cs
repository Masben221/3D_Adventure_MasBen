using SimpleFPS;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    [SerializeField] private int bonus;

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed += bonus;  
            fps.m_WalkSpeed += bonus;  
            fps.m_RunSpeed += bonus;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FirstPersonController fps = other.GetComponent<FirstPersonController>();

        if (fps != null)
        {
            fps.m_JumpSpeed -= bonus;
            fps.m_WalkSpeed -= bonus;
            fps.m_RunSpeed -= bonus;
        }
    }
}
