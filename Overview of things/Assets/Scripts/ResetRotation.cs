using UnityEngine;

public class ResetRotation : MonoBehaviour
{
    public Transform targetObject; //������, �� ������� ��������� - ����� ������� SpawnPoint
    public static float pointRotation = 0f;

    public static void PlusPointRotation(float point)
    {
        pointRotation += point;
    }

    public void PerformResetRotation()
    {
        transform.Rotate(Vector3.up, -pointRotation);
        pointRotation = 0f;
    }
}
