using MySceneManagement;
using UnityEngine;

public class EscMenu : Panel
{
    private Panel settingsPanel;

    public void Continue() => Close();

    public void Settings() => settingsPanel.Open();

    public void ExitToMainMenu()
    {
        Close();
        SceneManager.LoadScene(CurentScenes.mainMenu);
    }


    public override void Initialize(bool isExternalPanel, Panel settingsPanel)
    {
        this.settingsPanel = settingsPanel;
        base.Initialize(isExternalPanel, settingsPanel);
    }

    protected override void Subscribe()
    {
        OnClose += settingsPanel.Close;
        KeyEventBus.OnEscape += Open;
    }

    protected override void UnSubscribe()
    {
        OnClose -= settingsPanel.Close;
        KeyEventBus.OnEscape -= Open;
    }
}