namespace MVCPattern.Logic.Views
{
    public class InputView
    {
        #region fields
        private Controllers.IController _controller;
        #endregion fields

        public InputView(Controllers.IController controller)
        {
            _controller = controller;
        }

        public void Run()
        {
            string? input;

            do
            {
                Console.Write($"Text[{_controller.LanguageCode}]: ");
                input = Console.ReadLine() ?? string.Empty;
                _controller.SetText(input);
            } while (string.IsNullOrWhiteSpace(input) == false);
        }
    }
}
