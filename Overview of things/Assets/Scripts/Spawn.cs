using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // Массив префабов для спавна
    public Transform spawnPoint;         // Точка спавна
    public int objectIndexToSpawn = 0;   // Индекс объекта для спавна по умолчанию
    public bool spawnOnStart = true;   // Спавнить ли при старте
    public float spawnDelay = 1f;       // Задержка между спавнами (опционально)
    private float nextSpawnTime = 0f; // Время следующего спавна (опционально)

    public bool repeatable = false;  // Спавнить ли раз за разом
    private GameObject currentSpawnedObject; //Для сохранения текущего объекта

    void Start()
    {
        if (spawnOnStart)
            SpawnObject(objectIndexToSpawn);
    }
    public void Update()
    {
        if (repeatable && Time.time >= nextSpawnTime)
        {
            SpawnObject(objectIndexToSpawn);
        }
    }

    // Вызываем этот метод при старте, или из другого скрипта
    public void SpawnObject(int index)
    {
        if (prefabsToSpawn.Length == 0 || spawnPoint == null)
        {
            Debug.LogError("Не настроены префабы для спавна или точка спавна!", gameObject);
            return;
        }
        if (index < 0 || index >= prefabsToSpawn.Length)
        {
            Debug.LogError("Недопустимый индекс префаба: " + index, gameObject);
            return;
        }
        // Удаление текущего объекта
        if (currentSpawnedObject != null)
        {
            Destroy(currentSpawnedObject);
            currentSpawnedObject = null;
        }
        GameObject prefab = prefabsToSpawn[index];
        // Спавн объекта
        if (prefab != null)
        {
            currentSpawnedObject = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation, spawnPoint);
            currentSpawnedObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f); //Устанавливаем  масштаб, который нужен
        }
        else
        {
            Debug.LogWarning("Префаб по индексу: " + index + " равен null. Проверьте список.", gameObject);
        }

        // Установка времени следующего спавна (опционально)
        if (repeatable)
            nextSpawnTime = Time.time + spawnDelay;
    }
    public void SetIndex(int index)
    {
        objectIndexToSpawn = index;
    }
}