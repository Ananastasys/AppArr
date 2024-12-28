using UnityEngine;

public class RotateRight : MonoBehaviour
{
    public float rotationSpeed = 5f; // �������� �������� (�������� � �������)

    public void PerformRotateRight()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
        ResetRotation.PlusPointRotation(rotationSpeed);
    }
}
