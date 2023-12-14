using UnityEngine;

namespace VehicleSpace
{
    public sealed class VehicleEngine
    {
        private Transform vehicleTransform;

        private float verticalInput;
        private float horizontalInput;

        private const float maxSpeed = 0.3f;
        private const float turnSpeed = 1.0f;

        public VehicleEngine(Transform vehicleTransform) => this.vehicleTransform = vehicleTransform;

        public void Gaz(float touchSense)
        {
            verticalInput = touchSense;
            vehicleTransform.Translate(Vector3.forward * CalculateVerticalInput());
        }

        public void Steer(float touchSense)
        {
            horizontalInput = touchSense;
            vehicleTransform.Rotate(Vector3.up, CalculateHorizontalInput());
        }

        private float CalculateVerticalInput() => verticalInput * maxSpeed;

        private float CalculateHorizontalInput() => horizontalInput * turnSpeed;
    }
}