namespace MVCPattern.Logic.Views
{
    public class InputView
    {
        #region fields
        private Controllers.Controller _controller;
        #endregion fields

        public InputView(Controllers.Controller controller)
        {
            _controller = controller;
        }

        public void Run()
        {
            var input = string.Empty;

            do
            {
                Console.Write("Text: ");
                input = Console.ReadLine() ?? string.Empty;
                _controller.SetText(input);
            } while (string.IsNullOrWhiteSpace(input) == false);
        }
    }
}
