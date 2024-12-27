using UnityEngine;

public class SpawnClock : MonoBehaviour
{
    public Spawn spawner; // —сылка на скрипт Spawn
    public int objectToSpawnIndex = 0;  // »ндекс объекта, который нужно спавнить

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
