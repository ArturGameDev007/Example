using UnityEngine;

public class Temlate : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        MoveToWall();
    }

    private void MoveToWall()
    {
        Vector3 directionToTarget = _target.position - transform.position;
        Vector3 normalizeDirection = directionToTarget.normalized;

        Vector3 move = normalizeDirection * _speed * Time.deltaTime;

        transform.position += move;

    }
}
