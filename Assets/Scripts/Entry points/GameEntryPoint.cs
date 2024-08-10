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
        [SerializeField] private Clock clock;

        private void Start()
        {
            if (!isInit)
            {
                InitCatalogs();
                clock.StartClock();
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