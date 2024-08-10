using System;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    public class MainMenuEntryPoint : MonoBehaviour, IEntryPoint
    {
        [SerializeField] SettingsPanel settingsPanel;


        public static bool isInit = false;
        public static event Action<bool> OnStateUpdated;

        private void Awake()
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