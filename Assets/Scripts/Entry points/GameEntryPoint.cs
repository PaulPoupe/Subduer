using System;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour, IEntryPoint
{
    public static bool isInit { get; private set; }
    public static event Action<bool> OnStateUpdated;

    [SerializeField] private ScriptableObject[] catalogs;

    private void Start()
    {
        if (!isInit)
        {
            InitCatalogs();

            isInit = true;
        }

        OnStateUpdated?.Invoke(isInit);
    }

    private void InitCatalogs()
    {
        if (catalogs != null)
        {
            CatalogInitializator catalogInitializator = new CatalogInitializator();
            catalogInitializator.Initialize(catalogs);
        }
    }

}