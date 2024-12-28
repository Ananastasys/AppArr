using UnityEngine;

public class RotateLeft : MonoBehaviour
{
    public float rotationSpeed = -5f; // �������� �������� (�������� � �������)

    public void PerformRotateLeft()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
        ResetRotation.PlusPointRotation(rotationSpeed);
    }
}