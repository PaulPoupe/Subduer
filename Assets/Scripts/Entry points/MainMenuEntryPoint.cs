using System;
using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour, IEntryPoint
{
    [SerializeField] private LoadingPanel loadingPanel;

    public static bool isInit = false;
    public static event Action<bool> OnInited;

    private void Awake()
    {
        loadingPanel.Initialize();
        //Init...
        //Init...
        //Init...
        //Init...

        isInit = true;
        OnInited?.Invoke(isInit);
    }
}