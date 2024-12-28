using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabsToSpawn; // ������ �������� ��� ������
    public Transform spawnPoint;         // ����� ������
    public int objectIndexToSpawn = 0;   // ������ ������� ��� ������ �� ���������
    public bool spawnOnStart = true;   // �������� �� ��� ������
    public float spawnDelay = 1f;       // �������� ����� �������� (�����������)
    private float nextSpawnTime = 0f; // ����� ���������� ������ (�����������)

    public bool repeatable = false;  // �������� �� ��� �� �����
    private GameObject currentSpawnedObject; //��� ���������� �������� �������

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

    // �������� ���� ����� ��� ������, ��� �� ������� �������
    public void SpawnObject(int index)
    {
        if (prefabsToSpawn.Length == 0 || spawnPoint == null)
        {
            Debug.LogError("�� ��������� ������� ��� ������ ��� ����� ������!", gameObject);
            return;
        }
        if (index < 0 || index >= prefabsToSpawn.Length)
        {
            Debug.LogError("������������ ������ �������: " + index, gameObject);
            return;
        }
        // �������� �������� �������
        if (currentSpawnedObject != null)
        {
            Destroy(currentSpawnedObject);
            currentSpawnedObject = null;
        }
        GameObject prefab = prefabsToSpawn[index];
        // ����� �������
        if (prefab != null)
        {
            currentSpawnedObject = Instantiate(prefab, spawnPoint.position, spawnPoint.rotation, spawnPoint);
            currentSpawnedObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f); //�������������  �������, ������� �����
        }
        else
        {
            Debug.LogWarning("������ �� �������: " + index + " ����� null. ��������� ������.", gameObject);
        }

        // ��������� ������� ���������� ������ (�����������)
        if (repeatable)
            nextSpawnTime = Time.time + spawnDelay;
    }
    public void SetIndex(int index)
    {
        objectIndexToSpawn = index;
    }
}