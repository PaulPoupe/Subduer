using System;
using UnityEngine;

public enum Panels
{
    EscapePanel,
    SettingsPanel,
}


[Serializable]
public class PanelCreator : MonoBehaviour
{
    private const int panelsCount = 2;

    [SerializeField] private Panel[] _panelPrefabs;
    private static Panel[] panelPrefabs = new Panel[panelsCount];

    public PanelCreator()
    {
        panelPrefabs = _panelPrefabs;
    }

    public Panel CreateSettingsPanel(Transform parentPanel)
    {
        return Instantiate(panelPrefabs[(int)Panels.SettingsPanel], parentPanel);
    }

}