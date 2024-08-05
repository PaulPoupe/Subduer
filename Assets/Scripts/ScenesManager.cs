using System;
using UnityEngine;

using UnityEngine.SceneManagement;

public static class ScenesManager
{
    private static AsyncOperation asyncOperation;
    public static event Action<AsyncOperation, MySceneManagement.Scene> OnLoading;

    public static void LoadScene(MySceneManagement.Scene scene)
    {
        asyncOperation = SceneManager.LoadSceneAsync(scene.name);
        asyncOperation.allowSceneActivation = false;
        OnLoading?.Invoke(asyncOperation, scene);
    }

}