using MySceneManagement;
using UnityEngine;


public class MainMenuButtons : MonoBehaviour
{
    [SerializeField] private Panel settingsPanel;

    public void Continue() => SceneManager.LoadScene(CurentScenes.game);
    public void NewGame() => SceneManager.LoadScene(CurentScenes.game);
    public void Settings() => settingsPanel.Open();
    public void ExitToDescktop() => SceneManager.Quit();
}