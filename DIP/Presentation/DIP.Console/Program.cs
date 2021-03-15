using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using Common;
using DIP.Windows;

namespace DIP.Console
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Configure();

      var service = new LicenseService();
      var license = service.CreateLicense("Ivan");
      service.ShowLicenseInfo(license);
    }

    private static void Configure()
    {
      Dependency.RegisterType<ICodeGenerator, CodeGenerator>();
      Dependency.RegisterType<IDialogService, DialogService>();
    }
  }
}
