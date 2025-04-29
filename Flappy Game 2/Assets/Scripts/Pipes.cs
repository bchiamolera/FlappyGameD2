using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
