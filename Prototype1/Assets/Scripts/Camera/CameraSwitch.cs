using UnityEngine;

namespace CameraSpace
{
    public sealed class CameraSwitch
    {
        public void SetState(Camera camera, CameraState cameraState, Transform cameraTransform)
        {
            CameraState = cameraState;
            cameraState.SetCamera(camera);
            cameraState.SetTransform(cameraTransform);
        }

        public void MoveCamera() => CameraState.Move();

        public CameraState CameraState { get; set; }
    }
}