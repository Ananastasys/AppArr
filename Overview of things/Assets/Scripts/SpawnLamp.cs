using UnityEngine;

public class SpawnLamp : MonoBehaviour
{
    public Spawn spawner; // —сылка на скрипт Spawn
    public int objectToSpawnIndex = 1;  // »ндекс объекта, который нужно спавнить

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
