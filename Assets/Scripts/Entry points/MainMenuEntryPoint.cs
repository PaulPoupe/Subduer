using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    internal class MainMenuEntryPoint : EntryPoint
    {
        [SerializeField] Panel settingsPanel;

        private void Start()
        {
            settingsPanel.Initialize(true);
            //Init...
            //Init...
            //Init...


            Finish();
        }

        protected override void Finish()
        {
            OnStateUpdated?.Invoke(true);
        }

    }
}