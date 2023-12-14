using UnityEngine;

namespace CameraSpace
{
    public sealed class FrontState : CameraState
    {
        private Vector3 frontPoint = new Vector3(0, 2, 3);

        public override void Move() => camera.transform.position = targetTransform.position + frontPoint;

        public override void SetCamera(Camera camera) => this.camera = camera;

        public override void SetTransform(Transform targetTransform) =>
            this.targetTransform = targetTransform;
    }
}