using System;
using System.Collections.Generic;
using UnityEngine;

namespace LanguageSystem
{
    [CreateAssetMenu(fileName = "Text pocket", menuName = "My text/Text pocket")]
    public class TextLanguagePacket : ScriptableObject
    {
        [SerializeField] private Text[] texts;

        private Dictionary<Language, string> multyLangugeTexts = new Dictionary<Language, string>();

        public string outputText { get; private set; }
        public event Action OnUpdated;


        public void Initialize()
        {
            foreach (var text in texts)
            {
                text.Initialize();
                multyLangugeTexts.Add(text.language, text.text);
            }
        }

        public void SetLanguage(Language language)
        {
            if (multyLangugeTexts.ContainsKey(language))
                outputText = multyLangugeTexts[language];
            else
                outputText = multyLangugeTexts[Settings.language.defaultLanguage];
            OnUpdated?.Invoke();
        }

    }
}