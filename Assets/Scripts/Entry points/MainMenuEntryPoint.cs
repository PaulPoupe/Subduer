using UnityEngine;

public class MainMenuEntryPoint : MonoBehaviour
{
    [SerializeField] private LoadingPanel loadingPanel;

    private void Awake()
    {
        loadingPanel.Initialize();
    }
}