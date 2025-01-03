namespace MVCPattern.Logic.Controllers
{
    /// <summary>
    /// Represents a controller that manages the interaction between the model and the view.
    /// </summary>
    public sealed class Controller : IController
    {
        #region fields
        /// <summary>
        /// The model associated with this controller.
        /// </summary>
        private readonly Models.Model _model = new() { LanguageCode = "de" };
        #endregion fields

        #region properties
        /// <summary>
        /// Occurs when the model notifies of an event.
        /// </summary>
        public event EventHandler? NotifyEvent
        {
            add
            {
                _model.NotifyEvent += value;
            }
            remove
            {
                _model.NotifyEvent -= value;
            }
        }

        /// <summary>
        /// Gets the text from the model.
        /// </summary>
        public string Text
        {
            get
            {
                return _model.Text;
            }
        }

        /// <summary>
        /// Gets the language code from the model.
        /// </summary>
        public string LanguageCode
        {
            get
            {
                return _model.LanguageCode;
            }
        }
        #endregion properties

        #region methods
        /// <summary>
        /// Sets the text in the model if the provided text is not null or whitespace.
        /// </summary>
        /// <param name="text">The text to set in the model.</param>
        /// <returns>True if the text was set successfully; otherwise, false.</returns>
        public bool SetText(string text)
        {
            var result = false;

            if (string.IsNullOrWhiteSpace(text) == false)
            {
                _model.Text = text;
                result = true;
            }
            return result;
        }
        #endregion methods
    }
}
