using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveBullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _bullet;
    [SerializeField] private float _speedAttack;
    [SerializeField] private Transform _player;

    private void Awake()
    {
        _bullet = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 directionToPlayer = (_player.position - transform.position).normalized;
        Vector3 move = directionToPlayer * _speedAttack * Time.fixedDeltaTime;

        _bullet.velocity = move;
    }
}
