using UnityEngine;

public class MoveController : MonoBehaviour
{
    private PlayerInput playerInput;
    private CameraFollow cameraFollow;

    private void Awake()
    {
        playerInput = new PlayerInput(transform);
        cameraFollow = new CameraFollow(transform);
    }

    private void FixedUpdate() => playerInput.Move();

    private void LateUpdate() => cameraFollow.CalculatePositionAndMove();
}
