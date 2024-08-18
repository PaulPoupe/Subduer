using System.Collections;
using UnityEngine;

namespace MySceneManagement
{
    internal class LoadingScreen : MonoBehaviour
    {
        [SerializeField] private GameObject loadingScreen;
        [SerializeField] private Animator opacityAnimation;

        private IEnumerator StartAnimation(AsyncOperation asyncOperation, Scene scene)
        {
            loadingScreen.SetActive(true);

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
            SceneManager.OnLoading += OnStartAnimation;
            DontDestroyOnLoad(this);
        }

        private void ClosePanel()
        {
            loadingScreen.SetActive(false);
        }
    }
}