using System;
using LanguageSystem;

[Serializable]
public class Settings
{
    [NonSerialized]
    public static Settings instance = new Settings();

    public LanguageSettings language = new LanguageSettings();

    public void InitializeLanguageSettings(TextLanguagePacket[] textPokets)
    {
        language.Initialize(textPokets);
        language.SetLanguage();
    }
}