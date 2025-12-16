using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] public Enemy Enemy { get; private set; }

    public float DistanceToEnemy { get; private set; }
    public float MinDistanceForDetected { get; } = 5;

    public event Action<float> ChangeDistance;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 directionToEnemy = Enemy.transform.position - transform.position;

        DistanceToEnemy = directionToEnemy.magnitude;

        ChangeDistance?.Invoke(DistanceToEnemy);
    }
}
