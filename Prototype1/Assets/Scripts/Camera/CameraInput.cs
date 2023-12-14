using UnityEngine;

namespace CameraSpace
{
    public sealed class CameraInput
    {
        public bool IsPressingSwitchButton(KeyCode switchKey) => Input.GetKeyDown(switchKey);
    }
}