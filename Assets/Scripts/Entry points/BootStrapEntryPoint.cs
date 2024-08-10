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
        private static LoadingScreen loadingPanel;

        [Space(10.0f)]

        [SerializeField] private TextLanguagePacket[] allTextPokets;
        private const Language defaultLanguage = Language.Russian;

        public static bool isInit { get; protected set; }

        /* To do:
            Сделать инициализацию припомощи static ивентов нескольких уровней. 
            InitUi.Invoke();
        */

        private void Start()
        {
            if (loadingPanel == null)
                CreateLoadingPanel();

            if (!isInit)
            {
                InitializeLanguageManager();
                //Init...
                //Init...
                //Init...
                //Init...
                isInit = true;
            }

            SceneManager.LoadScene(CurentScenes.mainMenu);
        }

        private void InitializeLanguageManager()
        {
            LanguageManager languageManager = new LanguageManager();
            languageManager.Initialize(allTextPokets);
            LanguageManager.SetLanguage(defaultLanguage);
        }

        private void CreateLoadingPanel()
        {
            loadingPanel = Instantiate(loadingPanelPrefab);
            loadingPanel.Initialize();
        }
    }
}