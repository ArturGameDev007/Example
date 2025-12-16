using UnityEngine;

public class CollisionWithWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Столкнулись со стеной");
    }
}
