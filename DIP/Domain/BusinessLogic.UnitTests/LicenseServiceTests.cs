using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using BusinessLogic.UnitTests.CustomMocks;
using Common;
using NUnit.Framework;

namespace BusinessLogic.UnitTests
{
  public class LicenseServiceTests
  {
    [Test]
    public void CreateLicenseTest()
    {
      var expectedName = "John";
      var expectedCode = CodeGeneratorMock.GeneratedCode;

      Dependency.RegisterType<ICodeGenerator, CodeGeneratorMock>();

      var licenseService = new LicenseService();
      var license = licenseService.CreateLicense(expectedName);

      Assert.AreEqual(expectedName, license.OwnerName);
      Assert.AreEqual(expectedCode, license.Code);
    }
  }
}