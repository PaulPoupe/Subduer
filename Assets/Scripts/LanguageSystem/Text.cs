using UnityEngine;

namespace LanguageSystem
{
    public enum Language
    {
        English,
        Russian,
        Belarusian,
    }

    [CreateAssetMenu(fileName = "Text", menuName = "My text/Text")]
    internal class Text : ScriptableObject
    {
        [SerializeField] private Language _language;
        [SerializeField, TextArea(0, 999)] private string _text;

        public Language language { get; private set; }
        public string text { get; private set; }

        public void Initialize()
        {
            language = _language;
            text = _text;
        }
    }
}