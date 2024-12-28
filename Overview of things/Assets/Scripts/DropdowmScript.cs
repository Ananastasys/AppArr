using UnityEngine;
using TMPro;

public class DropdowmScript : MonoBehaviour
{
    public TMP_Dropdown dropdown; // Ссылка на ваш Dropdown объект

    public SpawnClock spawnClock; // Ссылка на скрипт часов
    public SpawnLamp spawnLamp; // Ссылка на скрипт лампы
    public SpawnMixer spawnMixer; // Ссылка на скрипт миксера
    public SpawnToaster spawnToaster; // Ссылка на скрипт тостера



    void Start()
    {
        // Убедитесь, что dropdown установлен, это важно
        if (dropdown == null)
        {
            Debug.LogError("Dropdown is not assigned to DropdowmScript script.");
            return;
        }

        // Подписываемся на событие изменения значения Dropdown
        dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
    }

    void OnDropdownValueChanged(int value)
    {
        // value - это индекс выбранного пункта в Dropdown (начиная с 0)

        switch (value)
        {
            case 0: // Выбран "Clock" (первый пункт в списке)
                if (spawnClock != null)
                spawnClock.SpawnSpecificObject(); // Вызываем метод SpawnSpecificObject скрипта часов
                else
                    Debug.LogWarning("SpawnClock not assigned to DropdowmScript script.");
                break;
            case 1: // Выбран "Lamp" (второй пункт в списке)
                if (spawnLamp != null)
                spawnLamp.SpawnSpecificObject(); // Вызываем метод SpawnSpecificObject скрипта лампы
                else
                    Debug.LogWarning("SpawnLamp not assigned to DropdowmScript script.");
                break;
            case 2: // Выбран "Mixer" (третий пункт в списке)
                if (spawnMixer != null)
                spawnMixer.SpawnSpecificObject(); // Вызываем метод SpawnSpecificObject скрипта миксера
                else
                    Debug.LogWarning("SpawnMixer not assigned to DropdowmScript script.");
                break;
            case 3: // Выбран "Toaster" (четвертый пункт в списке)
                if (spawnToaster != null)
                spawnToaster.SpawnSpecificObject(); // Вызываем метод SpawnSpecificObject скрипта тостера
                else
                    Debug.LogWarning("SpawnToaster not assigned to DropdowmScript script.");
                break;
            default:
                Debug.Log("Default case triggered in OnDropdownValueChanged, check the dropdown options");
                break;
        }
    }
}
