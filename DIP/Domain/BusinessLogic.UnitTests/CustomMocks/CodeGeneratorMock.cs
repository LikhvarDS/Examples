using BusinessLogic.Interfaces;

namespace BusinessLogic.UnitTests.CustomMocks
{
  internal class CodeGeneratorMock : ICodeGenerator
  {
    public static string GeneratedCode { get; } = "code";

    public string GenerateCode()
    {
      return GeneratedCode;
    }
  }
}
