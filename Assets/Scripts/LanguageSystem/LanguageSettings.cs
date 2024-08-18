using System;

namespace LanguageSystem
{
    public class LanguageSettings
    {
        public readonly Language defaultLanguage = Language.English;
        private event Action<Language> OnSetLanguage;

        public void Initialize(TextLanguagePacket[] textPokets)
        {
            if (textPokets == null)
                return;

            foreach (var textPoket in textPokets)
            {
                textPoket.Initialize();
                OnSetLanguage += textPoket.SetLanguage;
            }
        }

        public void SetLanguage(Language language) => OnSetLanguage?.Invoke(language);

        public void SetLanguage(int languageId) => SetLanguage((Language)languageId);

        public void SetLanguage() => SetLanguage(defaultLanguage);
    }
}