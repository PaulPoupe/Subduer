using System.Collections.Generic;
using UnityEngine;

public class Catalog<TItem> : MonoBehaviour where TItem : ICatalogable
{
    [SerializeField]
    private TItem[] serializedCatalog;

    private static readonly Dictionary<string, TItem> catalog;

    private void Awake()
    {
        WriteDictionary();
    }

    private void WriteDictionary()
    {
        foreach (var item in serializedCatalog)
        {
            catalog.Add(item.name, item);
        }
    }
}