namespace MVCPattern.Logic.Models
{
    /// <summary>
    /// Represents a model that extends the Subject class and notifies observers when the text changes.
    /// </summary>
    public class Model : Subject
    {
        #region fields
        /// <summary>
        /// Stores the text value.
        /// </summary>
        private string _text = string.Empty;

        /// <summary>
        /// Stores the language code, default is "de".
        /// </summary>
        private string languageCode = "de";
        #endregion fields

        #region properties
        /// <summary>
        /// Gets or sets the language code.
        /// </summary>
        public string LanguageCode 
        { 
            get => languageCode; 
            set => languageCode = value; 
        }

        /// <summary>
        /// Gets or sets the text. Notifies all observers if the text changes.
        /// </summary>
        public string Text 
        { 
            get => _text;
            set
            {
                if (_text != value)
                {
                    _text = value;
                    NotifyAll(new TextEventArgs(Text, LanguageCode));
                }
            }
        }
        #endregion properties
    }
}
