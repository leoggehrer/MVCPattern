namespace MVCPattern.Logic.Controllers
{
  /// <summary>
  /// Represents a controller interface that defines properties and methods for handling text and language code.
  /// </summary>
  public interface IController
  {
    /// <summary>
    /// Gets the text associated with the controller.
    /// </summary>
    string Text { get; }

    /// <summary>
    /// Gets the language code associated with the text.
    /// </summary>
    string LanguageCode { get; }

    /// <summary>
    /// Sets the text for the controller.
    /// </summary>
    /// <param name="text">The text to be set.</param>
    /// <returns>True if the text was successfully set; otherwise, false.</returns>
    bool SetText(string text);
  }
}

