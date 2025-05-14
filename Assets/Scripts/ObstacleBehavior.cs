using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{

    [SerializeField] private float speed;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
