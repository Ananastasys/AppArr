using UnityEngine;

public class SpawnClock : MonoBehaviour
{
    public Spawn spawner; // ������ �� ������ Spawn
    public int objectToSpawnIndex = 0;  // ������ �������, ������� ����� ��������

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
