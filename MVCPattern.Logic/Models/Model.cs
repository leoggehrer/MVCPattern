namespace MVCPattern.Logic.Models
{
    public class Model : Subject
    {
        #region fields
        private string _text = string.Empty;
        private string languageCode = "de";
        #endregion fields

        #region properties
        public string LanguageCode 
        { 
            get => languageCode; 
            set => languageCode = value; 
        }

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
