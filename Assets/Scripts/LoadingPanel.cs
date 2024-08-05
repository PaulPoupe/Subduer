using System.Collections;
using UnityEngine;

public class LoadingPanel : MonoBehaviour
{
    [SerializeField] private GameObject loadingPanel;
    [SerializeField] private Animator opacityAnimation;

    private IEnumerator StartAnimation(AsyncOperation asyncOperation)
    {
        loadingPanel.SetActive(true);

        while (asyncOperation.progress < 0.9f)
            yield return null;

        opacityAnimation.Play("Opacity1-0");

        asyncOperation.allowSceneActivation = true;

        while (opacityAnimation.GetCurrentAnimatorStateInfo(0).normalizedTime < 1)
            yield return null;

        ClosePanel();
    }

    private void OnStartAnimation(AsyncOperation asyncOperation) => StartCoroutine(StartAnimation(asyncOperation));

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