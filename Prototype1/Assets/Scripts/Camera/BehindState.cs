using UnityEngine;

namespace CameraSpace
{
    public sealed class BehindState : CameraState
    {
        private Vector3 behindPoint = new Vector3(0, 6, -9);

        public override void Move() => camera.transform.position = targetTransform.position + behindPoint;

        public override void SetCamera(Camera camera) => this.camera = camera;

        public override void SetTransform(Transform targetTransform) =>
            this.targetTransform = targetTransform;
    }
}