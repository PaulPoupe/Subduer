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
        [SerializeField] private Panel escMenu;
        [SerializeField] private Panel settingsPanel;

        protected override void Init()
        {
            void InitCatalogs()
            {
                if (catalogs != null)
                {
                    CatalogInitializator catalogInitializator = new CatalogInitializator();
                    catalogInitializator.Initialize(catalogs);
                }
            }

            InitCatalogs();
            escMenu.Initialize(true, settingsPanel);
            settingsPanel.Initialize(false);
            clock.StartClock();
        }

        protected override void Finish()
        {
            OnStateUpdated?.Invoke(true);
        }

        protected override void UnSubscribe()
        {
            settingsPanel.UnSubscribe();
        }
    }
}