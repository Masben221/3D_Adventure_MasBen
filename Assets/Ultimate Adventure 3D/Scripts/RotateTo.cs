using UnityEngine;

public class RotateTo : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3 target;

    private void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(target), speed * Time.deltaTime);
        //transform.eulerAngles = Vector3.MoveTowards(transform.eulerAngles, target, speed * Time.deltaTime);
    }
}
