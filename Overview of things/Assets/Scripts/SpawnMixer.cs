using UnityEngine;

public class SpawnMixer : MonoBehaviour
{
    public Spawn spawner; // ������ �� ������ Spawn
    public int objectToSpawnIndex = 2;  // ������ �������, ������� ����� ��������

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
