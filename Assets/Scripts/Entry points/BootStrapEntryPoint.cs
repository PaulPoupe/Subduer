using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrapEntryPoint : MonoBehaviour
{
    private void Awake()
    {
        SceneManager.LoadScene(1);
    }
}