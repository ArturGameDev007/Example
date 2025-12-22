using UnityEngine;

namespace Assets.Scripts.DorExaple
{
    public class DotDetectedEnemy : MonoBehaviour
    {
        [SerializeField] private EnemyForFollow _enemy;

        private void Update()
        {
            if (_enemy == null)
            {
                Debug.LogError("Вы не указали  сылку на врага.");
            }
            else
            {
                DetectedObject();
            }
        }

        private void DetectedObject()
        {
            Vector3 directionForward = transform.forward;
            Vector3 directionTotarget = (_enemy.transform.position - transform.position).normalized;

            float dotResult = Vector3.Dot(directionForward, directionTotarget);

            string message =
                (dotResult > 0.5f) ? "Враг спереди" :
                (dotResult < -0.5f) ? "Враг сзади" :
                (Mathf.Abs(dotResult) < 0.1f) ? "Враг рядом" : "Враг где-то еще";

            Debug.Log(message);
        }
    }
}
