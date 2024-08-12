using System;

namespace LanguageSystem
{
    public class LanguageManager
    {
        public static Language defaultLanguage { get; private set; }
        private static event Action<Language> OnSetLanguage;

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

        public static void SetLanguage(Language language) => OnSetLanguage?.Invoke(language);

        public static void SetLanguage(int languageId) => SetLanguage((Language)languageId);

        public static void SetLanguage() => SetLanguage(defaultLanguage);
    }
}