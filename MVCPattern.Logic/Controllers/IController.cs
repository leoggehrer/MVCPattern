namespace MVCPattern.Logic.Controllers
{
  public interface IController
  {
    string Text { get; }
    string LanguageCode { get; }
    
    bool SetText(string text);
  }
}

