using UnityEngine;

public interface ICameraState
{
    void EnterState(Vector3 cameraOffset, Transform targetTransfrom);
    void Move();
}