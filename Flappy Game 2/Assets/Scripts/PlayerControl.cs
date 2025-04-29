using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocity;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.linearVelocity = Vector3.up * velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Collidable"))
        {
            FindFirstObjectByType<GameManager>().GameOver();
        }
    }
}
