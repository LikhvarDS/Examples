using System;
using BusinessLogic.Interfaces;

namespace DIP.Windows
{
  public class CodeGenerator : ICodeGenerator
  {
    public string GenerateCode()
    {
      return Guid.NewGuid().ToString();
    }
  }
}
