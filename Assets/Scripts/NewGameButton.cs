using UnityEngine;

public class NewGameButton : MonoBehaviour
{
    public void NewGame() => ScenesManager.LoadScene("Game");
}