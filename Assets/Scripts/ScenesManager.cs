using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class ScenesManager
{
    private static AsyncOperation asyncOperation;
    public static event Action<AsyncOperation> OnLoading;

    public static void LoadScene(string name)
    {
        asyncOperation = SceneManager.LoadSceneAsync(name);
        asyncOperation.allowSceneActivation = false;
        OnLoading?.Invoke(asyncOperation);
    }

}