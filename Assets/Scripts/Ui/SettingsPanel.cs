using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _settingsPanelPrefab;
    private static GameObject settingsPanelPrefab;
    private static GameObject settingPanel;


    public void Initialize()
    {
        settingsPanelPrefab = _settingsPanelPrefab;
    }

    public static void Open(Transform transform)
    {
        if (settingPanel == null)
            settingPanel = Instantiate(settingsPanelPrefab, transform);
        else
            Destroy(settingPanel);
    }
}