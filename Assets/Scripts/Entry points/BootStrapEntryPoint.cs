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
        [SerializeField] private TextLanguagePacket[] allTextPokets;


        private void Start()
        {
            if (loadingPanel == null)
                CreateLoadingScreen();

            InitializeLanguageManager();
            //Init...
            //Init...
            //Init...
            //Init...

            OnStateUpdated?.Invoke(true);
            SceneManager.LoadScene(CurentScenes.mainMenu);
        }

        private void InitializeLanguageManager()
        {
            LanguageManager languageManager = new LanguageManager();
            languageManager.Initialize(allTextPokets);
            LanguageManager.SetLanguage();
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