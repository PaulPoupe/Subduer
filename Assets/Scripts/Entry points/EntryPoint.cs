using System;
using MySceneManagement;
using UnityEngine;

namespace EntryPoint
{
    internal abstract class EntryPoint : MonoBehaviour
    {
        public static Action<bool> OnStateUpdated;
        protected static LoadingScreen loadingPanel;

        protected abstract void Finish();
        protected abstract void OnDestroy();
    }

}