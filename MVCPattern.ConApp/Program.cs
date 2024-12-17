namespace MVCPattern.ConApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MVC-Pattern");
            Console.WriteLine();

            var input = string.Empty;
            var controller = new Logic.Controllers.Controller();
            var translationView1 = new Logic.Views.TranslationView("en");
            var translationView2 = new Logic.Views.TranslationView("fr");
            var translationView3 = new Logic.Views.TranslationView("es");

            Console.Write("DeepL-ApiKey: ");
            Logic.Translator.DeepLTranslator.ApiKey = Console.ReadLine() ?? string.Empty;

            controller.NotifyEvent += translationView1.Update!;
            controller.NotifyEvent += translationView2.Update!;
            controller.NotifyEvent += translationView3.Update!;

            var inputView = new Logic.Views.InputView(controller);

            inputView.Run();

            controller.NotifyEvent -= translationView1.Update!;
            controller.NotifyEvent -= translationView2.Update!;
            controller.NotifyEvent -= translationView3.Update!;
        }
    }
}
