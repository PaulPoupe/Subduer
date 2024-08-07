using System;

namespace LanguageSystem
{
    public class LanguageManager
    {
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

        public static void SetLanguage(Language language)
        {
            OnSetLanguage?.Invoke(language);
        }
    }
}