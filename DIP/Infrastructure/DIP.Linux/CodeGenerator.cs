using BusinessLogic.Interfaces;
using LinuxCodeGenerator;

namespace DIP.Windows
{
  public class CodeGenerator : ICodeGenerator
  {
    public string GenerateCode()
    {
      return SuperDuperCodeGenerator.GenerateSuperCode();
    }
  }
}
