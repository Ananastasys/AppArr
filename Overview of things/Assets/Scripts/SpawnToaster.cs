using UnityEngine;

public class SpawnToaster : MonoBehaviour
{
    public Spawn spawner; // ������ �� ������ Spawn
    public int objectToSpawnIndex = 3;  // ������ �������, ������� ����� ��������

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
