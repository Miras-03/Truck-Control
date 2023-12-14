using UnityEngine;
using VehicleSpace.VehicleCommand;

namespace VehicleSpace
{
    public sealed class CommandController
    {
        private readonly RightSideCommand rightCommand;
        private readonly LeftSideCommand leftCommand;

        public CommandController(VehicleEngine firstVehicle, VehicleEngine secondVehicle)
        {
            rightCommand = new RightSideCommand(firstVehicle);
            leftCommand = new LeftSideCommand(secondVehicle);
        }

        public void HandleRightSide() => rightCommand.ExecuteControl();

        public void HandleLeftSide() => leftCommand.ExecuteControl();
    }
}