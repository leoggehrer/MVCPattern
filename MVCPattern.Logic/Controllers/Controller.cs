using System.Runtime.CompilerServices;

namespace MVCPattern.Logic.Controllers
{
    public sealed class Controller
    {
        #region fields
        private readonly Models.Model _model = new() { LanguageCode = "de" };
        #endregion fields

        #region properties
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
        #endregion properties

        #region methods
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
