using System.Collections.Generic;
using UnityEngine;

public abstract class Catalog<TItem> : ScriptableObject, ICatalog where TItem : ICatalogable
{
    [SerializeField]
    private TItem[] serializedCatalog;

    private static readonly Dictionary<string, TItem> catalog = new Dictionary<string, TItem>();

    public void Initialize()
    {
        foreach (var item in serializedCatalog)
            catalog.Add(item.name, item);
    }

    public IReadOnlyDictionary<string, TItem> GetCatalog() => catalog;

    public TItem GetType(string typeName) => catalog[typeName];
}