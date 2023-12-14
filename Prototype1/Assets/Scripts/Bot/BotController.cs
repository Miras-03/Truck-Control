using UnityEngine;

public class BotController : MonoBehaviour
{
    [SerializeField] private Transform[] botTransforms;
    private const int speed = 15;

    private void FixedUpdate()
    {
        foreach (Transform t in botTransforms)
            t.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
    }
}
