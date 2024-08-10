using UnityEngine;
using LanguageSystem;
using MySceneManagement;

namespace EntryPoint
{
    [DisallowMultipleComponent]
    [AddComponentMenu("Entry points/ Bootstrap entry point")]
    public class BootStrapEntryPoint : MonoBehaviour, IEntryPoint
    {
        public static bool isInit = false;
        //public static event Action<bool> OnStateUpdated;

        [SerializeField] private LoadingScreen loadingPanelPrefab;
        private static LoadingScreen loadingPanel;

        [Space(10.0f)]

        [SerializeField] private TextLanguagePacket[] allTextPokets;
        private const Language defaultLanguage = Language.Russian;

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