using System;

public class LanguageManager
{
    private static event Action<Language> OnSetLanguage;

    public void Initialize(TextPoket[] textPokets)
    {
        foreach (var textPoket in textPokets)
        {
            textPoket.Initialize();
            OnSetLanguage += textPoket.SetLanguage;
        }
    }

    public static void SetLanguage(Language language)
    {
        OnSetLanguage?.Invoke(language);
    }
}