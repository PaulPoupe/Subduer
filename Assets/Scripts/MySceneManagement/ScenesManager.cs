using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MySceneManagement
{
    public static class ScenesManager
    {
        private static AsyncOperation asyncOperation;
        public static event Action<AsyncOperation, Scene> OnLoading;

        public static void LoadScene(Scene scene)
        {
            asyncOperation = SceneManager.LoadSceneAsync(scene.name);
            asyncOperation.allowSceneActivation = false;
            OnLoading?.Invoke(asyncOperation, scene);
        }

    }
}