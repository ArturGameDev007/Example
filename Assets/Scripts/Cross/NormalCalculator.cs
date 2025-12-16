using UnityEngine;

public class NormalCalculator : MonoBehaviour
{
    [SerializeField] private Transform _target;


    private void Update()
    {
        Result();
    }

    private void Result()
    {
        Vector3 directionToTarget = _target.position - transform.position;
        directionToTarget.y = 0;

        Vector3 crossProductResult = Vector3.Cross(transform.forward, directionToTarget.normalized);

        if (crossProductResult.y > 0)
        {
            Debug.Log("Цель справа от меня");
        }
        else if (crossProductResult.y < 0)
        {
            Debug.Log("Цель слева от меня");
        }
        else
        {
            Debug.Log("Цель прямо передо мной или позади");
        }
    }
}
