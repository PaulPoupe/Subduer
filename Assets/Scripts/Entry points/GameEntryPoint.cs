using System;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour, IEntryPoint
{
    public static bool isInit = false;
    public static event Action<bool> OnInited;

    [SerializeField] private ScriptableObject[] catalogs;

    private void Start()
    {
        InitCatalogs();

        isInit = true;
        OnInited?.Invoke(isInit);

        void InitCatalogs()
        {
            if (catalogs == null)
                return;

            CatalogInitializator catalogInitializator = new CatalogInitializator();
            catalogInitializator.Initialize(catalogs);
        }
    }

}