using UnityEngine;

namespace Assets.Scripts.Test
{
    public class FollowObject : MonoBehaviour
    {
        [SerializeField] private CharacterController _player;
        [SerializeField] private float _speed;

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 directionToTarget = _player.transform.position - transform.position;
            Vector3 normalizeDirection = directionToTarget.normalized;

            Vector3 move = normalizeDirection * _speed * Time.deltaTime;

            transform.position += move;
            //transform.position = transform.position + move; идентично
            //Используя +=, вы заставляете объект шагать из текущей точки в сторону цели.
        }
    }
}
