using UnityEngine;

namespace VehicleSpace
{
    public sealed class VehicleController : MonoBehaviour
    {
        [Space(20)]
        [Header("VehicleTransforms")]
        [SerializeField] private Transform fiirstVehicleTransform;
        [SerializeField] private Transform secondVehicleTransform;

        private Transform vehicleTransform;

        private VehicleEngine firstVehicleEngine;
        private VehicleEngine secondVehicleEngine;

        private CommandController commandController;

        private void Awake()
        {
            firstVehicleEngine = new VehicleEngine(fiirstVehicleTransform);
            secondVehicleEngine = new VehicleEngine(secondVehicleTransform);

            commandController = new CommandController(firstVehicleEngine, secondVehicleEngine);
        }

        private void FixedUpdate()
        {
            commandController.HandleRightSide();
            commandController.HandleLeftSide();
        }

        public Transform VehicleTransform => vehicleTransform;
    }
}