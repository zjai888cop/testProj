using UnityEngine;

public class RotateY : MonoBehaviour
{
    public float fScaleSpeed = 1.0f;
    [SerializeField] private float rotationSpeed = 90f;

    private void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime * fScaleSpeed);
    }
}
