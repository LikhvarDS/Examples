using BusinessLogic.Interfaces;

namespace DIP.Console
{
  /// <summary>
  /// Сервис диалогов.
  /// </summary>
  /// <remarks>
  /// В консоле нет диалогов, поэтому просто выводим строки в консоль.
  /// </remarks>
  public class DialogService : IDialogService
  {
    public void ShowData(params string[] data)
    {
      foreach (var str in data)
        System.Console.WriteLine(str);
    }
  }
}
