using UnityEngine;

public class CameraFollow
{
    private Transform playerTransform;
    private Transform cameraTransform;

    private Vector3 offset;

    public CameraFollow(Transform playerTransform)
    {
        this.playerTransform = playerTransform;

        SetCameraTransform();
        SetOffset();
    }

    private void SetCameraTransform() => cameraTransform = Camera.main.transform;

    private void SetOffset() => offset = cameraTransform.position;

    public void CalculatePositionAndMove() => cameraTransform.position = playerTransform.position + offset;
}
