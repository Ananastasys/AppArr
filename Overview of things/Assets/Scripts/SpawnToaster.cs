using UnityEngine;

public class SpawnToaster : MonoBehaviour
{
    public Spawn spawner; // —сылка на скрипт Spawn
    public int objectToSpawnIndex = 3;  // »ндекс объекта, который нужно спавнить

    public void SpawnSpecificObject()
    {
        spawner.SpawnObject(objectToSpawnIndex);
    }
}
