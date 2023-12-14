using UnityEngine;

namespace VehicleSpace.VehicleCommand
{
    public sealed class LeftSideCommand : IVehicleCommand
    {
        private readonly VehicleEngine vehicleEngine;

        public LeftSideCommand(VehicleEngine vehicleEngine) => this.vehicleEngine = vehicleEngine;

        public void ExecuteControl() => CheckVehicleForControlling();

        private void CheckVehicleForControlling()
        {
            if (IsPedalTouching())
                vehicleEngine.Gaz(GetVerInput());
            if (IsSteering())
                vehicleEngine.Steer(GetHorInput());
        }

        private bool IsPedalTouching() => GetVerInput() != 0;

        private bool IsSteering() => GetHorInput() != 0;

        private float GetVerInput() => Input.GetAxis("LeftVertical");

        private float GetHorInput() => Input.GetAxis("LeftHorizontal");
    }
}