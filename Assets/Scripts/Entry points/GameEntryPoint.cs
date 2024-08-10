using Catalogs;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Game entry point")]
    internal class GameEntryPoint : EntryPoint
    {
        [SerializeField] private ScriptableObject[] catalogs;
        [SerializeField] private Clock clock;
        [SerializeField] private EscMenu escMenu;

        public static bool isInit { get; protected set; }

        private void Start()
        {
            if (!isInit)
            {
                InitCatalogs();
                escMenu.Initialize();
                clock.StartClock();
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