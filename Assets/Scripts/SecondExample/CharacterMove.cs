using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMove : MonoBehaviour
{
    [SerializeField] private CharacterController _controller;

    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private void Awake()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move(_moveDirection);
    }

    public void Move(Vector3 moveDirection)
    {
        _moveDirection = moveDirection;
        _controller.Move(moveDirection * _speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, _moveDirection);

        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(Vector3.zero, _moveDirection + transform.position);

        Gizmos.color = Color.blue;
        Gizmos.DrawRay(Vector3.zero, transform.position);
    }
}
