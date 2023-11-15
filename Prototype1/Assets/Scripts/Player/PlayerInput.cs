using UnityEngine;

public class PlayerInput
{
    private Transform playerTransform;

    private float verticalInput;
    private float horizontalInput;

    private const float maxSpeed = 10f;
    private const float turnSpeed = 20f;

    public PlayerInput(Transform playerTransform) => this.playerTransform = playerTransform;

    public void Move()
    {
        GetInput();

        playerTransform.Translate(Vector3.forward * CalculateVerticalInput());
        playerTransform.Rotate(Vector3.up, CalculateHorizontalInput());
    }

    private void GetInput()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private float CalculateVerticalInput() => verticalInput = verticalInput * Time.fixedDeltaTime * maxSpeed;

    private float CalculateHorizontalInput() => horizontalInput = horizontalInput * Time.fixedDeltaTime * turnSpeed;
}
