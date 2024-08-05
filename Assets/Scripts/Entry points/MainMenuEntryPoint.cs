using System;
using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour, IEntryPoint
{
    [SerializeField] private LoadingPanel loadingPanelPrefab;

    private static LoadingPanel loadingPanel;

    public static bool isInit = false;
    public static event Action<bool> OnUpdated;

    private void Awake()
    {
        if (loadingPanel == null)
        {
            loadingPanel = Instantiate(loadingPanelPrefab);
            loadingPanel.Initialize();
        }

        if (!isInit)
        {
            //Init...
            //Init...
            //Init...
            //Init...
            isInit = true;
        }

        OnUpdated?.Invoke(isInit);
    }
}