using MySceneManagement;
using UnityEngine;


public class MainMenuButtons : MonoBehaviour
{
    public void Continue() => SceneManager.LoadScene(CurentScenes.game);
    public void NewGame() => SceneManager.LoadScene(CurentScenes.game);
    public void Settings() => SettingsPanel.Open(transform.parent);
}