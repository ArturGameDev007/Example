using Assets.Scripts.Method;
using UnityEngine;

public class NormalizeMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Character _player;


    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 directionToPlayer = (_player.transform.position - transform.position).normalized;

        Vector3 move = directionToPlayer * _speed * Time.deltaTime;

        transform.position += move;
    }
}
