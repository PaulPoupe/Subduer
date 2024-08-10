using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MySceneManagement
{
    public static class SceneManager
    {
        private static AsyncOperation asyncOperation;
        public static event Action<AsyncOperation, Scene> OnLoading;

        public static void LoadScene(Scene scene)
        {
            asyncOperation = UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(scene.name);
            asyncOperation.allowSceneActivation = false;
            OnLoading?.Invoke(asyncOperation, scene);
        }

    }
}