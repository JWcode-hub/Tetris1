using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Vector2 moveInput;
    public PlayerInput playerInput;
    public GameManager gameManager; // Reference to get the latest block

    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        playerInput.actions.Enable();
    }

    void Update()
    {
        moveInput = playerInput.actions["Move"].ReadValue<Vector2>();

        // Get the latest spawned block
        TetrisBlock currentBlock = gameManager.GetCurrentBlock();
        if (currentBlock != null)
        {
            currentBlock.Move(moveInput); // Move the newest block
        }
    }
}