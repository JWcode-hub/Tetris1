using UnityEngine;

public class TetrisBlock : MonoBehaviour
{
    private Rigidbody2D rb;

    // Add speed for movement
    public float moveSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Ensure Rigidbody2D is attached
    }

    public void Move(Vector2 direction)
    {
        // Move the block by modifying its position (use Rigidbody2D for physics-based movement)
        rb.linearVelocity = direction * moveSpeed; // Apply movement based on direction (left-right, down)
    }
}