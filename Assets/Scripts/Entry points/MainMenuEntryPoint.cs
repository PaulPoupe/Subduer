using System;
using UnityEngine;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Main menu entry point")]
    public class MainMenuEntryPoint : MonoBehaviour, IEntryPoint
    {


        public static bool isInit = false;
        public static event Action<bool> OnStateUpdated;

        private void Awake()
        {
            if (!isInit)
            {
                //Init...
                //Init...
                //Init...
                //Init...
                isInit = true;
            }

            OnStateUpdated?.Invoke(isInit);
        }


    }
}