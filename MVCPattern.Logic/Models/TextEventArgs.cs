namespace MVCPattern.Logic.Models
{
    /// <summary>
    /// Provides data for text-related events.
    /// </summary>
    public class TextEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the text associated with the event.
        /// </summary>
        public string Text { get; }

        /// <summary>
        /// Gets the language code of the text associated with the event.
        /// </summary>
        public string LanguageCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextEventArgs"/> class.
        /// </summary>
        /// <param name="text">The text associated with the event.</param>
        /// <param name="languageCode">The language code of the text.</param>
        public TextEventArgs(string text, string languageCode)
        {
            Text = text;
            LanguageCode = languageCode;
        }
    }
}
