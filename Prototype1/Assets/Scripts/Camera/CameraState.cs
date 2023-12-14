using UnityEngine;

namespace CameraSpace
{
    public abstract class CameraState
    {
        protected Camera camera;
        protected Transform targetTransform;

        public abstract void Move();
        public abstract void SetCamera(Camera camera);
        public abstract void SetTransform(Transform targetTransform);
    }
}