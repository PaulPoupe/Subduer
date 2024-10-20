using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    internal class MainMenuEntryPoint : EntryPoint
    {
        [SerializeField] Panel settingsPanel;

        protected override void Init()
        {
            settingsPanel.Initialize(true);
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