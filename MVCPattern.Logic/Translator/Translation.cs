namespace MVCPattern.Logic.Translator
{
    public class Translation
    {
        /// <summary>
        /// The original text (or HTML) that was translated.
        /// </summary>
        public required string OriginalText { get; init; }

        /// <summary>
        /// The translated text.
        /// </summary>
        public required string TranslatedText { get; init; }

        /// <summary>
        /// The source language code detected by the server. This may
        /// be null, typically due to the source language being supplied
        /// by the caller.
        /// </summary>
        public required string DetectedSourceLanguage { get; init; }

        /// <summary>
        /// The source language code supplied by the caller, if any.
        /// </summary>
        public required string SpecifiedSourceLanguage { get; init; }

        /// <summary>
        /// The target language code that the text was translated into.
        /// </summary>
        public required string TargetLanguage { get; init; }
    }
}
