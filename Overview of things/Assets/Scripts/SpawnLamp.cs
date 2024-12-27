using UnityEngine;

public class SpawnLamp : MonoBehaviour
{
    public Spawn spawner; // ������ �� ������ Spawn
    public int objectToSpawnIndex = 1;  // ������ �������, ������� ����� ��������

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
