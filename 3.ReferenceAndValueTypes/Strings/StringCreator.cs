using System.Text;

namespace Strings
{
  public class StringCreator
  {
    public void BuildString()
    {
      string result = string.Empty;
      for (var i = 0; i < 1000; i++)
      {
        result += "word";
      }

      // ИЛИ

      StringBuilder builder = new StringBuilder();
      for (var i = 0; i < 1000; i++)
      {
        builder.Append("word");
      }

      result = builder.ToString();
    }
  }
}
