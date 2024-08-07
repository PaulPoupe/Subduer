using System;
using Catalogs;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Game entry point")]
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
                //Init...
                //Init...
                //Init...
                //Init...
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
}