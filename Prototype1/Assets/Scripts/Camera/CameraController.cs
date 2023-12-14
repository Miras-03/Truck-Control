using UnityEngine;

namespace CameraSpace
{
    public class CameraController : MonoBehaviour
    {
        [Header("Cameras")]
        [SerializeField] private Camera firstVehicleCamera;
        [SerializeField] private Camera secondVehicleCamera;

        [Header("VehicleTransforms")]
        [SerializeField] private Transform firstVehicleTransform;
        [SerializeField] private Transform secondVehicleTransform;

        private CameraSwitch firstCameraSwitch;
        private CameraSwitch secondCameraSwitch;

        private CameraInput cameraInput;

        private void Awake()
        {
            firstCameraSwitch = new CameraSwitch();
            secondCameraSwitch = new CameraSwitch();

            firstCameraSwitch.SetState(firstVehicleCamera, new BehindState(), firstVehicleTransform);
            secondCameraSwitch.SetState(secondVehicleCamera, new BehindState(), secondVehicleTransform);

            cameraInput = new CameraInput();
        }

        private void Update()
        {
            if (cameraInput.IsPressingSwitchButton(KeyCode.E))
                SwitchFirstCamera();
            if (cameraInput.IsPressingSwitchButton(KeyCode.L))
                SwitchSecCamera();
        }

        private void LateUpdate()
        {
            firstCameraSwitch.MoveCamera();
            secondCameraSwitch.MoveCamera();
        }

        private void SwitchFirstCamera()
        {
            if (firstCameraSwitch.CameraState is FrontState)
                firstCameraSwitch.SetState(firstVehicleCamera, new BehindState(), firstVehicleTransform);
            else
                firstCameraSwitch.SetState(firstVehicleCamera, new FrontState(), firstVehicleTransform);
        }

        private void SwitchSecCamera()
        {
            if (secondCameraSwitch.CameraState is FrontState)
                secondCameraSwitch.SetState(secondVehicleCamera, new BehindState(), secondVehicleTransform);
            else
                secondCameraSwitch.SetState(secondVehicleCamera, new FrontState(), secondVehicleTransform);
        }
    }
}