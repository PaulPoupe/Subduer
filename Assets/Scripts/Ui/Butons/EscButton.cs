using System;
using MySceneManagement;
using UnityEngine;

public class EscButton : MonoBehaviour
{
    public void ReturnMainMenu() => ScenesManager.LoadScene(SceneTitleManager.mainMenu);
}