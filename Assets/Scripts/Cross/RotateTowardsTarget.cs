using UnityEngine;

public class RotateTowardsTarget : MonoBehaviour
{
    [SerializeField] private Transform _targetEnemy;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        RotateTowards();
    }

    private void RotateTowards()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 directionTotarget = (_targetEnemy.position - transform.position).normalized;

        Vector3 rotateAxis = Vector3.Cross(forward, directionTotarget);

        transform.Rotate(rotateAxis, _rotationSpeed * Time.deltaTime);
    }
}
