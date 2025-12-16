using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _speed;
    [SerializeField] private float _minDistanceForDetected;

    private Vector3 _enemyPosition;
    private Vector3 _directionToPlayer;

    private float _distanceToPlayer;

    private void Start()
    {
        _enemyPosition = transform.position;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _directionToPlayer = _player.transform.position - _enemyPosition;
        _distanceToPlayer = _directionToPlayer.magnitude;

        if (_distanceToPlayer < _minDistanceForDetected)
        {
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, _speed * Time.deltaTime);
        }
    }
}
