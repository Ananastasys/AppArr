using UnityEngine;

public class SpawnMixer : MonoBehaviour
{
    public Spawn spawner; // —сылка на скрипт Spawn
    public int objectToSpawnIndex = 2;  // »ндекс объекта, который нужно спавнить

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
