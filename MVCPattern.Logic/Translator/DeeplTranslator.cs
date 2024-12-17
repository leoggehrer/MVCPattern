using DeepL;

namespace MVCPattern.Logic.Translator
{
    public partial class DeepLTranslator
    {
        public static string ApiKey { get; set; } = string.Empty;
        public static string ConvertLanguageCode(string code)
        {
            var result = code;

            if (code == "en")
            {
                result = LanguageCode.EnglishBritish;
            }
            return result;
        }

        /// <summary>
        /// Retrieves a DeepL translation asynchronously.
        /// </summary>
        /// <param name="key">The text to be translated.</param>
        /// <param name="keyLanguage">The language code of the text to be translated.</param>
        /// <param name="valueLanguage">The target language code for the translation.</param>
        /// <returns>A Task representing the translation result.</returns>
        public static async Task<Translation> GetTranslationAsync(string key, string? keyLanguage, string valueLanguage)
        {
            var textToTranslate = key;
            var sourceLanguage = string.IsNullOrEmpty(keyLanguage) == false ? ConvertLanguageCode(keyLanguage!) : null;
            var targetLanguage = ConvertLanguageCode(valueLanguage);
            using var translator = new DeepL.Translator(ApiKey);
            var result = await translator.TranslateTextAsync(textToTranslate, sourceLanguage, targetLanguage).ConfigureAwait(false);

            return new Translation
            {
                OriginalText = textToTranslate,
                TranslatedText = result.Text,
                DetectedSourceLanguage = result.DetectedSourceLanguageCode,
                SpecifiedSourceLanguage = sourceLanguage ?? string.Empty,
                TargetLanguage = targetLanguage
            };
        }
    }
}