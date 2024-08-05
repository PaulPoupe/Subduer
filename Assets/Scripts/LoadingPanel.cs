using System.Collections;
using MySceneManagement;
using UnityEngine;

public class LoadingPanel : MonoBehaviour
{
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private Animator opacityAnimation;

    private IEnumerator StartAnimation(AsyncOperation asyncOperation, Scene scene)
    {
        loadingPanel.SetActive(true);

        while (asyncOperation.progress < 0.9f)
            yield return null;

        asyncOperation.allowSceneActivation = true;

        while (!scene.isInit)
            yield return null;

        opacityAnimation.Play("Opacity1-0");

        while (opacityAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;

        ClosePanel();
    }

    private void OnStartAnimation(AsyncOperation asyncOperation, Scene scene) => StartCoroutine(StartAnimation(asyncOperation, scene));

    public void Initialize()
    {
        ScenesManager.OnLoading += OnStartAnimation;
        DontDestroyOnLoad(this);
    }

    private void ClosePanel()
    {
        loadingPanel.SetActive(false);
    }
}