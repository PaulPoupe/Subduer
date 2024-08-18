public class SettingsPanel : Panel
{
    public override void Initialize()
    {
        KeyEventBus.OnEscape += Close;
    }

    protected override void UnSubscribe()
    {
        KeyEventBus.OnEscape -= Close;
    }

    public void SetLanguage(int languageId) => Settings.language.SetLanguage(languageId);
}