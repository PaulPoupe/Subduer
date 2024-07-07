using UnityEngine;

public abstract class Item : ScriptableObject, ICatalogable
{
    [field: SerializeField]
    public Sprite iconImage { get; private set; }
    [field: SerializeField]
    public new string name { get; private set; }
    [field: SerializeField, TextArea]
    public string description { get; private set; }
    [field: SerializeField]
    public int size { get; private set; }
}