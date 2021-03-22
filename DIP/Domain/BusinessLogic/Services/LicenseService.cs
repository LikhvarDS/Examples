using BusinessLogic.Interfaces;
using BusinessLogic.Models;
using Common;

namespace BusinessLogic.Services
{
  public class LicenseService
  {
    public License CreateLicense(string name)
    {
      var generator = Dependency.Reslove<ICodeGenerator>();
      var code = generator.GenerateCode();
      return new License(name, code);
    }

    public void ShowLicenseInfo(License license)
    {
      var service = Dependency.Reslove<IDialogService>();
      service.ShowData(license.OwnerName, license.Code);
    }
  }
}
