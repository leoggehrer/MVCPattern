namespace MVCPattern.Logic.Models
{
    public class TextEventArgs : EventArgs
    {
        public string Text { get; }
        public string LanguageCode { get; }
        public TextEventArgs(string text, string languageCode)
        {
            Text = text;
            LanguageCode = languageCode;
        }
    }
}
