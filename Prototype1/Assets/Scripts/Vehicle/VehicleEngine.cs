using UnityEngine;

namespace VehicleSpace
{
    public sealed class VehicleEngine
    {
        private Transform vehicleTransform;
        private Rigidbody rb;

        private int horsePower;
        private const int powerAmount = 100;
        private float verticalInput;
        private float horizontalInput;
        private const float turnSpeed = 1.0f;

        public VehicleEngine(Transform vehicleTransform, Rigidbody rb, int horsePower)
        {
            this.vehicleTransform = vehicleTransform;
            this.rb = rb;
            this.horsePower = horsePower * powerAmount;
        }

        public void Gaz(float touchSense)
        {
            verticalInput = touchSense;
            rb.AddRelativeForce(Vector3.forward * CalculateVerticalMove());
        }

        public void Steer(float touchSense)
        {
            horizontalInput = touchSense;
            vehicleTransform.Rotate(Vector3.up, CalculateHorizontalMove());
        }

        private float CalculateVerticalMove() => verticalInput * horsePower;

        private float CalculateHorizontalMove() => horizontalInput * turnSpeed;
    }
}