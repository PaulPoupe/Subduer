using MySceneManagement;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public void Continue() => Close();
    public void Settings() => SettingsPanel.Open(transform.parent);
    public void ExitToMainMenu()
    {
        Close();
        SceneManager.LoadScene(CurentScenes.mainMenu);
    }

    /*  To do:
        1. перемещение Esc панели в сторону от панели настроек.
        2. fix баг при перезаходе и повторном открытии.
    */


    public void Initialize()
    {
        KeyEventBus.Escape += Open;
    }

    private void Open()
    {
        if (!gameObject.activeInHierarchy)
            gameObject.SetActive(true);

        else
            Close();
    }

    private void Close()
    {
        gameObject.SetActive(false);
    }

    private void UnSubscribe() => KeyEventBus.Escape -= Open;

    private void OnDestroy()
    {
        Close();
        UnSubscribe();
    }
}