using UnityEngine;

namespace VehicleSpace
{
    public sealed class VehicleController : MonoBehaviour
    {
        [Space(20)]
        [Header("FirstVehicle")]
        [SerializeField] private Transform fiirstVehicleTransform;
        [SerializeField] private Rigidbody firstRb;
        [SerializeField] private int firstHorsePower = 300;

        [Space(20)]
        [Header("SecondVehicle")]
        [SerializeField] private Transform secondVehicleTransform;
        [SerializeField] private Rigidbody secondRb;
        [SerializeField] private int secondHorsePower = 300;

        private Transform vehicleTransform;

        private VehicleEngine firstVehicleEngine;
        private VehicleEngine secondVehicleEngine;

        private CommandController commandController;

        private void Awake()
        {
            firstVehicleEngine = new VehicleEngine(fiirstVehicleTransform, firstRb, firstHorsePower);
            secondVehicleEngine = new VehicleEngine(secondVehicleTransform, secondRb, secondHorsePower);

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