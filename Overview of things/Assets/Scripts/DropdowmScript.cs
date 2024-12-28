using UnityEngine;
using TMPro;

public class DropdowmScript : MonoBehaviour
{
    public TMP_Dropdown dropdown; // ������ �� ��� Dropdown ������

    public SpawnClock spawnClock; // ������ �� ������ �����
    public SpawnLamp spawnLamp; // ������ �� ������ �����
    public SpawnMixer spawnMixer; // ������ �� ������ �������
    public SpawnToaster spawnToaster; // ������ �� ������ �������



    void Start()
    {
        // ���������, ��� dropdown ����������, ��� �����
        if (dropdown == null)
        {
            Debug.LogError("Dropdown is not assigned to DropdowmScript script.");
            return;
        }

        // ������������� �� ������� ��������� �������� Dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDropdownValueChanged(int value)
    {
        // value - ��� ������ ���������� ������ � Dropdown (������� � 0)

        switch (value)
        {
            case 0: // ������ "Clock" (������ ����� � ������)
                if (spawnClock != null)
                spawnClock.SpawnSpecificObject(); // �������� ����� SpawnSpecificObject ������� �����
                else
                    Debug.LogWarning("SpawnClock not assigned to DropdowmScript script.");
                break;
            case 1: // ������ "Lamp" (������ ����� � ������)
                if (spawnLamp != null)
                spawnLamp.SpawnSpecificObject(); // �������� ����� SpawnSpecificObject ������� �����
                else
                    Debug.LogWarning("SpawnLamp not assigned to DropdowmScript script.");
                break;
            case 2: // ������ "Mixer" (������ ����� � ������)
                if (spawnMixer != null)
                spawnMixer.SpawnSpecificObject(); // �������� ����� SpawnSpecificObject ������� �������
                else
                    Debug.LogWarning("SpawnMixer not assigned to DropdowmScript script.");
                break;
            case 3: // ������ "Toaster" (��������� ����� � ������)
                if (spawnToaster != null)
                spawnToaster.SpawnSpecificObject(); // �������� ����� SpawnSpecificObject ������� �������
                else
                    Debug.LogWarning("SpawnToaster not assigned to DropdowmScript script.");
                break;
            default:
                Debug.Log("Default case triggered in OnDropdownValueChanged, check the dropdown options");
                break;
        }
    }
}
