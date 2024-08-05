using System;
using UnityEngine;

public class GameEntryPoint : MonoBehaviour, IEntryPoint
{
    public static bool isInit = false;
    public static event Action<bool> OnUpdated;

    [SerializeField] private ScriptableObject[] catalogs;

    private void Start()
    {
        if (!isInit)
        {
            InitCatalogs();

            isInit = true;
        }

        OnUpdated?.Invoke(isInit);

        void InitCatalogs()
        {
            if (catalogs == null)
                return;

            CatalogInitializator catalogInitializator = new CatalogInitializator();
            catalogInitializator.Initialize(catalogs);
        }
    }

}