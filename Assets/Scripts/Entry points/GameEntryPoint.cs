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


        private void Start()
        {
            InitCatalogs();
            escMenu.Initialize();
            clock.StartClock();
            //Init...
            //Init...
            //Init...

            OnStateUpdated?.Invoke(true);
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