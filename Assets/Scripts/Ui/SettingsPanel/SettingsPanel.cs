
public class SettingsPanel : Panel
{
    protected override void Subscribe()
    {
        if (isExternalPanel)
            KeyEventBus.OnEscape += Close;
    }

    protected override void UnSubscribe()
    {
        if (isExternalPanel)
            KeyEventBus.OnEscape -= Close;
    }

    public void SetLanguage(int languageId) => Settings.language.SetLanguage(languageId);
}