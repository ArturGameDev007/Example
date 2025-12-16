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
            Vector3 directionToPlayer = _player.transform.position - transform.position;
            Vector3 normalizedDirection = directionToPlayer.normalized;

            Vector3 move = normalizedDirection * _speed * Time.deltaTime;
            transform.position += move;
        }
    }
}
