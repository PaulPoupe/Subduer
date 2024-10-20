using System;
using MySceneManagement;
using UnityEngine;

namespace EntryPoint
{
    internal abstract class EntryPoint : MonoBehaviour
    {
        public static Action<bool> OnStateUpdated;
        protected static LoadingScreen loadingPanel;

        private void Start()
        {
            Init();
            Finish();
        }

        private void OnDestroy() => UnSubscribe();

        protected abstract void Init();
        protected abstract void Finish();
        protected virtual void UnSubscribe() { }
    }

}