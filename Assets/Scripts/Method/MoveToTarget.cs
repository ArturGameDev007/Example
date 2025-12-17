using Assets.Scripts.Method;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Character _player;
    [SerializeField] private float _speed;

    private Vector3 _moveToTarget;

    private void Update()
    {
        Move();
    }

    //vector.lerp
    private void Move()
    {
        _moveToTarget = Vector3.Lerp(transform.position, _player.transform.position, 0.001f);
        transform.position = _moveToTarget;
    }

    //private void Move()
    //{
    //    _moveToTarget = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
    //    transform.position = _moveToTarget;
    //}
}
