using LanguageSystem;

static public class Settings
{
    public static LanguageSettings language = new LanguageSettings();

    public static void InitializeLanguageSettings(TextLanguagePacket[] textPokets)
    {
        language.Initialize(textPokets);
        language.SetLanguage();
    }
}