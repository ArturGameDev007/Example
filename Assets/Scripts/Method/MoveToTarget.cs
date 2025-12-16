using Assets.Scripts.Method;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private Character _player;
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    //vector.lerp
    //private void Move()
    //{
    //    Vector3 direction = transform.position;
    //    direction = Vector3.Lerp(transform.position, _player.transform.position, 0.1f);
    //    transform.position = direction;
    //}

    private void Move()
    {
        Vector3 moveToPoint = transform.position;
        moveToPoint = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        transform.position = moveToPoint;
    }
}
