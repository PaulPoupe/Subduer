using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrapEntryPoint : MonoBehaviour, IEntryPoint
{
    public static bool isInit = false;

    [SerializeField] private TextPoket[] allTextPokets;
    private const Language defaultLanguage = Language.English;

    private void Awake()
    {
        InitializeLanguageManager();

        SceneManager.LoadScene(1);
    }

    private void InitializeLanguageManager()
    {
        LanguageManager languageManager = new LanguageManager();
        languageManager.Initialize(allTextPokets);
        LanguageManager.SetLanguage(defaultLanguage);
    }
}