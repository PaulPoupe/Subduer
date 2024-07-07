
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField]
    private MonoBehaviour[] _catalogs;

    private ICatalog[] catalogs;

    private void Awake()
    {
        GetCatalogs();

        foreach (var catalog in catalogs)
        {
            catalog.Initialize();
        }

        Destroy(this);
    }

    private void GetCatalogs()
    {
        for (int i = 0; i < _catalogs.Length; i++)
        {
            catalogs[i] = (ICatalog)_catalogs[i];
        }
    }

}