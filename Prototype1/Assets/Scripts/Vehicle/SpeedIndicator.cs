using System.Collections;
using TMPro;
using UnityEngine;

public sealed class SpeedIndicator : MonoBehaviour
{
    [Space(10)]
    [Header("UI")]
    [SerializeField] private TextMeshProUGUI speedIndicator;
    private Rigidbody rb;

    private const int perSecond = 1;

    private void Awake() => rb = GetComponent<Rigidbody>();

    private void Start() => StartCoroutine(UpdateSpeed());

    private IEnumerator UpdateSpeed()
    {
        while (true)
        {
            int currentSpeed = Mathf.RoundToInt(rb.velocity.magnitude);
            speedIndicator.text = $"Speed: {currentSpeed}";
            yield return new WaitForSeconds(perSecond);
        }
    }
}
