using UnityEngine;

public class RotateLeft : MonoBehaviour
{
    public float rotationSpeed = -5f; // Скорость поворота (градусов в секунду)

    public void PerformRotateLeft()
    {
        transform.Rotate(Vector3.up, rotationSpeed);
        ResetRotation.PlusPointRotation(rotationSpeed);
    }
}