using System;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    internal class MainMenuEntryPoint : EntryPoint
    {
        [SerializeField] SettingsPanel settingsPanel;

        private void Start()
        {
            settingsPanel.Initialize();
            //Init...
            //Init...
            //Init...


            OnStateUpdated?.Invoke(true);
        }


    }
}