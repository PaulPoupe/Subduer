using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrapEntryPoint : MonoBehaviour, IEntryPoint
{
    public static bool isInit = false;

    private void Awake()
    {
        SceneManager.LoadScene(1);
    }
}