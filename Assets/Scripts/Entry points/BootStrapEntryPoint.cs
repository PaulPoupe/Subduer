using UnityEngine;
using LanguageSystem;
using MySceneManagement;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Bootstrap entry point")]
    internal class BootStrapEntryPoint : EntryPoint
    {
        [SerializeField] private LoadingScreen loadingPanelPrefab;
        [Space(10.0f)]
        [SerializeField] private TextLanguagePacket[] textPokets;


        private void Start()
        {
            if (loadingPanel == null)
                CreateLoadingScreen();

            Settings.InitializeLanguageSettings(textPokets);
            //Init...
            //Init...
            //Init...
            //Init...

            Finish();
        }

        protected override void Finish()
        {
            OnStateUpdated?.Invoke(true);
            SceneManager.LoadScene(CurentScenes.mainMenu);
        }

        /* To do: 
            1. CreateLoadingPanel это не должно быть в этом классе.
        */
        private void CreateLoadingScreen()
        {
            loadingPanel = Instantiate(loadingPanelPrefab);
            loadingPanel.Initialize();
        }
    }
}