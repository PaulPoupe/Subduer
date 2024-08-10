using Unity.VisualScripting;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    private static GameObject prefab;

    private static bool isOpened;

    public void Initialize()
    {
        prefab = _prefab;
    }

    public static void Open(Transform parent)
    {

        if (!isOpened)
        {
            Instantiate(prefab, parent);
            isOpened = true;
        }
    }

    public void Close()
    {
        if (isOpened)
        {
            Destroy(this);
        }
    }

    private void OnDestroy()
    {
        isOpened = false;
    }
}