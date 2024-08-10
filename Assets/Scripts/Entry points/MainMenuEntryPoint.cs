using System;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    internal class MainMenuEntryPoint : EntryPoint
    {
        [SerializeField] SettingsPanel settingsPanel;

        public static bool isInit { get; protected set; }

        private void Start()
        {
            if (!isInit)
            {
                settingsPanel.Initialize();
                //Init...
                //Init...
                //Init...
                isInit = true;
            }

            OnStateUpdated?.Invoke(isInit);
        }


    }
}