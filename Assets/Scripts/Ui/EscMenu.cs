using MySceneManagement;
using UnityEngine;

public class EscMenu : MonoBehaviour
{
    [SerializeField] GameObject escPanel;
    private bool isOpen;

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
        UIGameManager.Escape += Open;
    }

    private void Open()
    {
        if (!isOpen)
        {
            isOpen = true;
            escPanel.SetActive(true);
        }
        else
        {
            Close();
        }
    }

    private void Close()
    {
        isOpen = false;
        escPanel.SetActive(false);
    }
}