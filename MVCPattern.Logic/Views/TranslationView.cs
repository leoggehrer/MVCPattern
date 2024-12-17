using MVCPattern.Logic.Models;

namespace MVCPattern.Logic.Views
{
    public class TranslationView
    {
        public string LanguageCode { get; set; }
        public string OriginalText { get; private set; } = string.Empty;
        public string TranslatedText { get; private set; } = string.Empty;

        public TranslationView(string languageCode)
        {
            LanguageCode = languageCode;
        }

        public void Update(object sender, EventArgs e)
        {
            if (e is TextEventArgs textEventArgs)
            {
                OriginalText = textEventArgs.Text ?? string.Empty;
                TranslatedText = Translator.DeepLTranslator.GetTranslationAsync(OriginalText, null, LanguageCode).Result.TranslatedText;
                Console.WriteLine($"[{LanguageCode}]: {TranslatedText}");
            }
        }
    }
}
