using MySceneManagement;
using UnityEngine;

public class ContinueGameButton : MonoBehaviour
{
    public void LoadGame() => ScenesManager.LoadScene(SceneTitleManager.game);
}