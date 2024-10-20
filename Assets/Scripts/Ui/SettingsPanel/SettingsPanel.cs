
public class SettingsPanel : Panel
{
    protected override void Subscribe()
    {
        if (isExternalPanel)
            KeyEventBus.OnEscape += Close;
    }

    public override void UnSubscribe()
    {
        if (isExternalPanel)
            KeyEventBus.OnEscape -= Close;
    }

    public void SetLanguage(int languageId) => Settings.instance.language.SetLanguage(languageId);
}