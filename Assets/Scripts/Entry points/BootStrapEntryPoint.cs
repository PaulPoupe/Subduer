using UnityEngine;
using LanguageSystem;
using MySceneManagement;

/* To do: 
    1. CreateLoadingPanel это не должно быть в этом классе.
*/

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Bootstrap entry point")]
    internal class BootStrapEntryPoint : EntryPoint
    {
        [SerializeField] private LoadingScreen loadingPanelPrefab;
        [Space(10.0f)]
        [SerializeField] private TextLanguagePacket[] textPokets;


        private void Awake()
        {
            if (loadingPanel == null)
                CreateLoadingScreen();
        }

        protected override void Init()
        {
            Settings.instance.InitializeLanguageSettings(textPokets);
        }

        protected override void Finish()
        {
            OnStateUpdated?.Invoke(true);
            SceneManager.LoadScene(CurentScenes.mainMenu);
        }

        private void CreateLoadingScreen()
        {
            loadingPanel = Instantiate(loadingPanelPrefab);
            loadingPanel.Initialize();
        }
    }
}