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
        Vector3 forward = transform.forward;
        Vector3 directionToTarget = (_targetEnemy.position - transform.position).normalized;

        Vector3 crossResult = Vector3.Cross(forward, directionToTarget);

        float speedRotate = _rotationSpeed * Time.deltaTime;

        transform.Rotate(crossResult, speedRotate);
    }
}
