using UnityEngine;
using UnityEngine.SceneManagement;

public class BootStrapEntryPoint : MonoBehaviour
{
    [SerializeField] private ScriptableObject[] catalogs;

    private CatalogInitializator catalogInitializator = new CatalogInitializator();

    private void Awake()
    {
        catalogInitializator.Initialize(catalogs);
        SceneManager.LoadScene(1);
    }
}